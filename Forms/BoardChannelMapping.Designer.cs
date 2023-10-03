namespace BC.Forms
{
    partial class FrmBoardChannelMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoardChannelMapping));
            this.ptbBoardChannelMapping = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBoardChannelMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbBoardChannelMapping
            // 
            this.ptbBoardChannelMapping.Image = global::BC.Properties.Resources.BoardChannelMapping;
            this.ptbBoardChannelMapping.Location = new System.Drawing.Point(0, -2);
            this.ptbBoardChannelMapping.Name = "ptbBoardChannelMapping";
            this.ptbBoardChannelMapping.Size = new System.Drawing.Size(1217, 673);
            this.ptbBoardChannelMapping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBoardChannelMapping.TabIndex = 0;
            this.ptbBoardChannelMapping.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(1052, 683);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 53);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmBoardChannelMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(1217, 750);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ptbBoardChannelMapping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBoardChannelMapping";
            this.Text = "Board Channel Mapping";
            ((System.ComponentModel.ISupportInitialize)(this.ptbBoardChannelMapping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbBoardChannelMapping;
        private System.Windows.Forms.Button btnOk;
    }
}