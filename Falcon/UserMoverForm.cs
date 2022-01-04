using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falcon
{
    public partial class UserMoverForm : Form
    {

        /*
         * These are used in calculations for the progress bar.
         */
        private float totalBytes = 0; 
        private float currentBytes = 0;

        public UserMoverForm()
        {
            InitializeComponent();
        }

        /*
         * When the browse button is clicked for the destination path show 
         * the folder browser dialog and update the textbox.
         */
        private void btnBrowseNew_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNew.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /*
         * When the move button is clicked launch the background worker
         * in async mode to leave the main thread running.
         */
        private void btnMove_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            worker.RunWorkerAsync();
        }

        /*
         * When the browse button is clicked for the original path show 
         * the folder browser dialog and update the textbox.
         */
        private void btnBrowseOriginal_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOriginal.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /*
         * Get the size of a specific directory. 
         */
        private long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }

        /*
         * This is where the directory copying is actually done.
         * This method is run async as to not hold the main thread.
         * This also allows the updating of the progress bar. 
         */
        private void worker_DoWork(object sender, DoWorkEventArgs @event)
        {
            try
            {
                DirectoryInfo orig = new DirectoryInfo(txtOriginal.Text); //Get the original directory from the textbox input.
                totalBytes = DirSize(orig); //Set the max bytes this is used in calculation of the progress bar.
                currentBytes = 0; //The current running total of bytes copied.

                // Get the subdirectories for the specified directory.
                DirectoryInfo rootDir = new DirectoryInfo(txtOriginal.Text);

                if (!rootDir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + txtOriginal.Text);
                }

                DirectoryInfo[] childDirs = rootDir.GetDirectories();

                Directory.CreateDirectory(txtNew.Text); // If the destination directory doesn't exist, create it.   

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = rootDir.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (worker.CancellationPending == true) //Check if the cancel button was pressed if so break.
                    {
                        @event.Cancel = true;
                        break;
                    }
                    string tempPath = Path.Combine(txtNew.Text, file.Name);
                    file.CopyTo(tempPath, false);
                    currentBytes += file.Length;
                    Console.WriteLine(currentBytes.ToString() + " / " + totalBytes.ToString());
                    double progressExact = (currentBytes / totalBytes) * 100;
                    int progressPercent = Convert.ToInt32(progressExact);
                    Console.WriteLine("Progress: "+ progressExact.ToString());
                    worker.ReportProgress(progressPercent);
                }

                //Start subdirectory copy
                if (!@event.Cancel)
                {
                    // If copying subdirectories, copy them and their contents to new location.
                    foreach (DirectoryInfo subDir in childDirs)
                    {
                        string tempPath = Path.Combine(txtNew.Text, subDir.Name);
                        rootDir = new DirectoryInfo(subDir.FullName);
                        childDirs = rootDir.GetDirectories();
                        Directory.CreateDirectory(tempPath);
                        files = rootDir.GetFiles();
                        foreach (FileInfo file in files)
                        {
                            if (worker.CancellationPending == true)
                            {
                                @event.Cancel = true;
                                break;
                            }
                            string fileTempPath = Path.Combine(tempPath, file.Name);
                            file.CopyTo(fileTempPath, false);
                            currentBytes += file.Length;
                            Console.WriteLine(currentBytes.ToString() + " / " +totalBytes.ToString());
                            double prog = (currentBytes / totalBytes) * 100;
                            int progress = Convert.ToInt32(prog);
                            Console.WriteLine("Progress: " + prog.ToString());
                            worker.ReportProgress(progress);
                        }
                    }
                    if (!@event.Cancel)
                    {
                        rootDir = new DirectoryInfo(txtNew.Text);
                        if (!rootDir.Exists)
                        {
                            MessageBox.Show("Unable to complete User Move please check directories and try again!", "User Mover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Move has been completed!", "User Mover", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        MessageBox.Show("Move has been canceled by user!", "User Mover", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    MessageBox.Show("Move has been canceled by user!", "User Mover", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                MessageBox.Show("Unable to complete User Move please check directories and try again!", "User Mover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Update the progress bar when the background worker is updated.
         */
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblByte.Text = e.ProgressPercentage.ToString() + "%";
            Console.WriteLine("User Mover: "+e.ProgressPercentage.ToString() + "%");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
        }
    }
}
