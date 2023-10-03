namespace BC.Forms
{
    partial class FrmLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLanguage));
            this.rdbPortuguese = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.ptbEnglish = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ptbPortuguese = new System.Windows.Forms.PictureBox();
            this.gpbSelectLanguage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortuguese)).BeginInit();
            this.gpbSelectLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPortuguese
            // 
            this.rdbPortuguese.AutoSize = true;
            this.rdbPortuguese.Location = new System.Drawing.Point(73, 168);
            this.rdbPortuguese.Name = "rdbPortuguese";
            this.rdbPortuguese.Size = new System.Drawing.Size(89, 20);
            this.rdbPortuguese.TabIndex = 0;
            this.rdbPortuguese.TabStop = true;
            this.rdbPortuguese.Text = "Português";
            this.rdbPortuguese.UseVisualStyleBackColor = true;
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Location = new System.Drawing.Point(235, 168);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(72, 20);
            this.rdbEnglish.TabIndex = 1;
            this.rdbEnglish.TabStop = true;
            this.rdbEnglish.Text = "English";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            // 
            // ptbEnglish
            // 
            this.ptbEnglish.Image = ((System.Drawing.Image)(resources.GetObject("ptbEnglish.Image")));
            this.ptbEnglish.Location = new System.Drawing.Point(217, 54);
            this.ptbEnglish.Name = "ptbEnglish";
            this.ptbEnglish.Size = new System.Drawing.Size(109, 98);
            this.ptbEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEnglish.TabIndex = 3;
            this.ptbEnglish.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(142, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 53);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ptbPortuguese
            // 
            this.ptbPortuguese.Image = ((System.Drawing.Image)(resources.GetObject("ptbPortuguese.Image")));
            this.ptbPortuguese.Location = new System.Drawing.Point(63, 54);
            this.ptbPortuguese.Name = "ptbPortuguese";
            this.ptbPortuguese.Size = new System.Drawing.Size(109, 98);
            this.ptbPortuguese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPortuguese.TabIndex = 2;
            this.ptbPortuguese.TabStop = false;
            // 
            // gpbSelectLanguage
            // 
            this.gpbSelectLanguage.Controls.Add(this.ptbPortuguese);
            this.gpbSelectLanguage.Controls.Add(this.ptbEnglish);
            this.gpbSelectLanguage.Controls.Add(this.rdbEnglish);
            this.gpbSelectLanguage.Controls.Add(this.rdbPortuguese);
            this.gpbSelectLanguage.Location = new System.Drawing.Point(27, 22);
            this.gpbSelectLanguage.Name = "gpbSelectLanguage";
            this.gpbSelectLanguage.Size = new System.Drawing.Size(390, 237);
            this.gpbSelectLanguage.TabIndex = 5;
            this.gpbSelectLanguage.TabStop = false;
            this.gpbSelectLanguage.Text = "Select Language";
            // 
            // FrmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 351);
            this.Controls.Add(this.gpbSelectLanguage);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLanguage";
            this.Text = "Change the Language";
            this.Load += new System.EventHandler(this.FrmLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortuguese)).EndInit();
            this.gpbSelectLanguage.ResumeLayout(false);
            this.gpbSelectLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPortuguese;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.PictureBox ptbEnglish;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox ptbPortuguese;
        private System.Windows.Forms.GroupBox gpbSelectLanguage;
    }
}