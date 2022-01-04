using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Falcon
{
    public partial class InstallForm : Form
    {
        private Dictionary<String, String> softwareList = new Dictionary<String, String>();

        public InstallForm()
        {
            InitializeComponent();
        }

        private void InstallForm_Load(object sender, EventArgs e)
        {
            softwareList.Clear();
            softwareList = getSoftwareList();
            foreach (String title in softwareList.Keys)
            {
                cmbSoftware.Items.Add(title);
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            String name = cmbSoftware.Text;
            String location = softwareList[name];
            Process.Start(location);
        }

        public static Dictionary<String, String> getSoftwareList() {
            Dictionary<String, String> tempList = new Dictionary<String, String>();
            XmlDocument xml = new XmlDocument();
            xml.Load("software.xml");
            XmlNodeList software = xml.GetElementsByTagName("software");
            bool errorShowed = false; //Used for showing an error if software.xml contains one.
            foreach (XmlNode softwareNode in software)
            {
                String title = "\\", location = "\\", copyright = "Unknown"; //copyright currently has no use though could be used in future.
                foreach (XmlNode childNode in softwareNode.ChildNodes)
                {
                    if (childNode.Name == "title")
                    {
                        title = childNode.InnerText;
                    }
                    else if (childNode.Name == "location")
                    {
                        location = childNode.InnerText;
                    }
                    else if (childNode.Name == "copyright")
                    {
                        copyright = childNode.InnerText;
                    }
                }
                if (title != "\\" && location != "\\")
                {
                    tempList.Add(title, location);
                }
                else
                {
                    if (!errorShowed) {
                        errorShowed = true;
                        MessageBox.Show("There was an error loading all software in the software.xml file. Please check the syntax and try again.", 
                            "Falcon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            return tempList;
        }
    }
}
