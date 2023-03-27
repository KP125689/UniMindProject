namespace UniMindProject
{
    partial class Samaritan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Samaritan));
            this.samaritansLabel = new System.Windows.Forms.Label();
            this.companyinfo = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.backArrow3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow3)).BeginInit();
            this.SuspendLayout();
            // 
            // samaritansLabel
            // 
            this.samaritansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samaritansLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.samaritansLabel.Location = new System.Drawing.Point(95, 104);
            this.samaritansLabel.Name = "samaritansLabel";
            this.samaritansLabel.Size = new System.Drawing.Size(243, 82);
            this.samaritansLabel.TabIndex = 0;
            this.samaritansLabel.Text = "Samaritans";
            this.samaritansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companyinfo
            // 
            this.companyinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyinfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.companyinfo.Location = new System.Drawing.Point(27, 236);
            this.companyinfo.Name = "companyinfo";
            this.companyinfo.Size = new System.Drawing.Size(373, 104);
            this.companyinfo.TabIndex = 1;
            this.companyinfo.Text = "*contact information goes here*";
            this.companyinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.companyinfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // descLabel
            // 
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descLabel.Location = new System.Drawing.Point(115, 374);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(211, 97);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "*description goes here";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backArrow3
            // 
            this.backArrow3.Image = ((System.Drawing.Image)(resources.GetObject("backArrow3.Image")));
            this.backArrow3.Location = new System.Drawing.Point(21, 24);
            this.backArrow3.Name = "backArrow3";
            this.backArrow3.Size = new System.Drawing.Size(81, 63);
            this.backArrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrow3.TabIndex = 3;
            this.backArrow3.TabStop = false;
            this.backArrow3.Click += new System.EventHandler(this.backArrow3_click);
            // 
            // Samaritan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(338, 466);
            this.Controls.Add(this.backArrow3);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.companyinfo);
            this.Controls.Add(this.samaritansLabel);
            this.Name = "Samaritan";
            this.Text = "Samaritan";
            this.Load += new System.EventHandler(this.Samaritan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrow3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label samaritansLabel;
        private System.Windows.Forms.Label companyinfo;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.PictureBox backArrow3;
    }
}