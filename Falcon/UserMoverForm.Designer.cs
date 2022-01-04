namespace Falcon
{
    partial class UserMoverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMoverForm));
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.btnBrowseOriginal = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnBrowseNew = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblByte = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.Location = new System.Drawing.Point(23, 103);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(290, 26);
            this.txtOriginal.TabIndex = 0;
            // 
            // btnBrowseOriginal
            // 
            this.btnBrowseOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOriginal.Location = new System.Drawing.Point(339, 99);
            this.btnBrowseOriginal.Name = "btnBrowseOriginal";
            this.btnBrowseOriginal.Size = new System.Drawing.Size(96, 34);
            this.btnBrowseOriginal.TabIndex = 1;
            this.btnBrowseOriginal.Text = "Browse";
            this.btnBrowseOriginal.UseVisualStyleBackColor = true;
            this.btnBrowseOriginal.Click += new System.EventHandler(this.btnBrowseOriginal_Click);
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(23, 150);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(290, 26);
            this.txtNew.TabIndex = 2;
            // 
            // btnBrowseNew
            // 
            this.btnBrowseNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseNew.Location = new System.Drawing.Point(339, 146);
            this.btnBrowseNew.Name = "btnBrowseNew";
            this.btnBrowseNew.Size = new System.Drawing.Size(96, 34);
            this.btnBrowseNew.TabIndex = 3;
            this.btnBrowseNew.Text = "Browse";
            this.btnBrowseNew.UseVisualStyleBackColor = true;
            this.btnBrowseNew.Click += new System.EventHandler(this.btnBrowseNew_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(138, 249);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(96, 34);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move!";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Mover";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 203);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 23);
            this.progressBar.TabIndex = 6;
            // 
            // lblByte
            // 
            this.lblByte.AutoSize = true;
            this.lblByte.Location = new System.Drawing.Point(379, 213);
            this.lblByte.Name = "lblByte";
            this.lblByte.Size = new System.Drawing.Size(0, 13);
            this.lblByte.TabIndex = 7;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(240, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 308);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblByte);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnBrowseNew);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.btnBrowseOriginal);
            this.Controls.Add(this.txtOriginal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMoverForm";
            this.Text = "Falcon - User Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button btnBrowseOriginal;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnBrowseNew;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblByte;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button btnCancel;
    }
}