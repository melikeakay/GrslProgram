namespace WinFormsApp2
{
    partial class PasswordForget
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.MailButton = new System.Windows.Forms.Button();
            this.KullanıcıLabel = new System.Windows.Forms.Label();
            this.KullanıcıTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(340, 161);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(153, 28);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Mail Adresiniz:";
            // 
            // MailTextBox
            // 
            this.MailTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MailTextBox.Location = new System.Drawing.Point(499, 149);
            this.MailTextBox.Multiline = true;
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(332, 40);
            this.MailTextBox.TabIndex = 1;
            this.MailTextBox.TextChanged += new System.EventHandler(this.MailTextBox_TextChanged);
            // 
            // MailButton
            // 
            this.MailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MailButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MailButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MailButton.Location = new System.Drawing.Point(613, 251);
            this.MailButton.Name = "MailButton";
            this.MailButton.Size = new System.Drawing.Size(218, 73);
            this.MailButton.TabIndex = 2;
            this.MailButton.Text = "Mail Gönder";
            this.MailButton.UseVisualStyleBackColor = false;
            this.MailButton.Click += new System.EventHandler(this.MailButton_Click);
            // 
            // KullanıcıLabel
            // 
            this.KullanıcıLabel.AutoSize = true;
            this.KullanıcıLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KullanıcıLabel.ForeColor = System.Drawing.Color.Black;
            this.KullanıcıLabel.Location = new System.Drawing.Point(340, 82);
            this.KullanıcıLabel.Name = "KullanıcıLabel";
            this.KullanıcıLabel.Size = new System.Drawing.Size(137, 28);
            this.KullanıcıLabel.TabIndex = 3;
            this.KullanıcıLabel.Text = "Kullanıcı Adı:";
            // 
            // KullanıcıTextBox
            // 
            this.KullanıcıTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.KullanıcıTextBox.Location = new System.Drawing.Point(499, 82);
            this.KullanıcıTextBox.Multiline = true;
            this.KullanıcıTextBox.Name = "KullanıcıTextBox";
            this.KullanıcıTextBox.Size = new System.Drawing.Size(332, 44);
            this.KullanıcıTextBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_lock_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 265);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(893, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KullanıcıTextBox);
            this.Controls.Add(this.KullanıcıLabel);
            this.Controls.Add(this.MailButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.NameLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PasswordForget";
            this.Text = "Şifremi Unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox MailTextBox;
        private Button MailButton;
        private Label KullanıcıLabel;
        private TextBox KullanıcıTextBox;
        private PictureBox pictureBox1;
    }
}