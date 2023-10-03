namespace BC.Forms
{
    partial class FrmConvertGameDataWeka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConvertGameDataWeka));
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblSelectDirectory = new System.Windows.Forms.Label();
            this.txtSelectDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(195, 157);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(161, 53);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "To Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblSelectDirectory
            // 
            this.lblSelectDirectory.AutoSize = true;
            this.lblSelectDirectory.Location = new System.Drawing.Point(45, 35);
            this.lblSelectDirectory.Name = "lblSelectDirectory";
            this.lblSelectDirectory.Size = new System.Drawing.Size(102, 16);
            this.lblSelectDirectory.TabIndex = 1;
            this.lblSelectDirectory.Text = "Select Directory";
            // 
            // txtSelectDirectory
            // 
            this.txtSelectDirectory.Location = new System.Drawing.Point(48, 55);
            this.txtSelectDirectory.Name = "txtSelectDirectory";
            this.txtSelectDirectory.Size = new System.Drawing.Size(545, 22);
            this.txtSelectDirectory.TabIndex = 2;
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(606, 51);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(107, 26);
            this.btnSelectDirectory.TabIndex = 3;
            this.btnSelectDirectory.Text = "Select ...";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(48, 101);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(665, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(386, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 53);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConvertGameDataWeka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(778, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.txtSelectDirectory);
            this.Controls.Add(this.lblSelectDirectory);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConvertGameDataWeka";
            this.Text = "Convert Game Data -> Weka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblSelectDirectory;
        private System.Windows.Forms.TextBox txtSelectDirectory;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCancel;
    }
}