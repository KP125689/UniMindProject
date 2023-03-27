namespace UniMindProject
{
    partial class register
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.passwordre_label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(56, 89);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(80, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "enter username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(56, 149);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(80, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Enter password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(59, 245);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(233, 65);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // passwordre_label
            // 
            this.passwordre_label.AutoSize = true;
            this.passwordre_label.Location = new System.Drawing.Point(56, 203);
            this.passwordre_label.Name = "passwordre_label";
            this.passwordre_label.Size = new System.Drawing.Size(91, 13);
            this.passwordre_label.TabIndex = 5;
            this.passwordre_label.Text = "re enter password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 357);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.passwordre_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label passwordre_label;
        private System.Windows.Forms.TextBox textBox3;
    }
}