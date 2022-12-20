namespace WinFormsApp2.Resources
{
    partial class EmployeeLogin
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
            this.EmployeeText = new System.Windows.Forms.Label();
            this.CashierLogingrpBx = new System.Windows.Forms.GroupBox();
            this.cashierCheckBox = new System.Windows.Forms.CheckBox();
            this.CashierLoginButton = new System.Windows.Forms.Button();
            this.PasswordForgetLink = new System.Windows.Forms.LinkLabel();
            this.cashierPasstext = new System.Windows.Forms.TextBox();
            this.cashierPassLabel = new System.Windows.Forms.Label();
            this.cashierIDLabel = new System.Windows.Forms.Label();
            this.CashierIdText = new System.Windows.Forms.TextBox();
            this.cashierPict = new System.Windows.Forms.PictureBox();
            this.PictruePage = new System.Windows.Forms.PictureBox();
            this.waiterLoginGrpBox = new System.Windows.Forms.GroupBox();
            this.WaitercheckBox = new System.Windows.Forms.CheckBox();
            this.waiterLoginButton = new System.Windows.Forms.Button();
            this.WaiterForgotLinkLabel = new System.Windows.Forms.LinkLabel();
            this.WaiterPassTxtBox = new System.Windows.Forms.TextBox();
            this.waiterPassLabel = new System.Windows.Forms.Label();
            this.WaiterIdTxtBox = new System.Windows.Forms.TextBox();
            this.waiterIDlabel = new System.Windows.Forms.Label();
            this.WaiterPict = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CashierLogingrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictruePage)).BeginInit();
            this.waiterLoginGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaiterPict)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeText
            // 
            this.EmployeeText.AutoSize = true;
            this.EmployeeText.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeText.Font = new System.Drawing.Font("Harlow Solid Italic", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EmployeeText.ForeColor = System.Drawing.Color.DarkRed;
            this.EmployeeText.Location = new System.Drawing.Point(781, 86);
            this.EmployeeText.Name = "EmployeeText";
            this.EmployeeText.Size = new System.Drawing.Size(294, 59);
            this.EmployeeText.TabIndex = 0;
            this.EmployeeText.Text = "Çalışan Girişi";
            // 
            // CashierLogingrpBx
            // 
            this.CashierLogingrpBx.BackColor = System.Drawing.Color.Transparent;
            this.CashierLogingrpBx.Controls.Add(this.cashierCheckBox);
            this.CashierLogingrpBx.Controls.Add(this.CashierLoginButton);
            this.CashierLogingrpBx.Controls.Add(this.PasswordForgetLink);
            this.CashierLogingrpBx.Controls.Add(this.cashierPasstext);
            this.CashierLogingrpBx.Controls.Add(this.cashierPassLabel);
            this.CashierLogingrpBx.Controls.Add(this.cashierIDLabel);
            this.CashierLogingrpBx.Controls.Add(this.CashierIdText);
            this.CashierLogingrpBx.Controls.Add(this.cashierPict);
            this.CashierLogingrpBx.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CashierLogingrpBx.ForeColor = System.Drawing.Color.DarkRed;
            this.CashierLogingrpBx.Location = new System.Drawing.Point(75, 161);
            this.CashierLogingrpBx.Name = "CashierLogingrpBx";
            this.CashierLogingrpBx.Size = new System.Drawing.Size(609, 617);
            this.CashierLogingrpBx.TabIndex = 1;
            this.CashierLogingrpBx.TabStop = false;
            this.CashierLogingrpBx.Text = "Kasiyer Girişi";
            this.CashierLogingrpBx.Enter += new System.EventHandler(this.CashierLogingrpBx_Enter);
            // 
            // cashierCheckBox
            // 
            this.cashierCheckBox.AutoSize = true;
            this.cashierCheckBox.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cashierCheckBox.Location = new System.Drawing.Point(485, 426);
            this.cashierCheckBox.Name = "cashierCheckBox";
            this.cashierCheckBox.Size = new System.Drawing.Size(95, 33);
            this.cashierCheckBox.TabIndex = 7;
            this.cashierCheckBox.Text = "Göster";
            this.cashierCheckBox.UseVisualStyleBackColor = true;
            this.cashierCheckBox.CheckedChanged += new System.EventHandler(this.cashierCheckBox_CheckedChanged);
            // 
            // CashierLoginButton
            // 
            this.CashierLoginButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CashierLoginButton.Location = new System.Drawing.Point(421, 533);
            this.CashierLoginButton.Name = "CashierLoginButton";
            this.CashierLoginButton.Size = new System.Drawing.Size(161, 58);
            this.CashierLoginButton.TabIndex = 6;
            this.CashierLoginButton.Text = "Giriş";
            this.CashierLoginButton.UseVisualStyleBackColor = false;
            this.CashierLoginButton.Click += new System.EventHandler(this.CashierLoginButton_Click);
            // 
            // PasswordForgetLink
            // 
            this.PasswordForgetLink.AutoSize = true;
            this.PasswordForgetLink.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PasswordForgetLink.LinkColor = System.Drawing.Color.DarkRed;
            this.PasswordForgetLink.Location = new System.Drawing.Point(28, 467);
            this.PasswordForgetLink.Name = "PasswordForgetLink";
            this.PasswordForgetLink.Size = new System.Drawing.Size(173, 29);
            this.PasswordForgetLink.TabIndex = 5;
            this.PasswordForgetLink.TabStop = true;
            this.PasswordForgetLink.Text = "Şifremi Unuttum";
            this.PasswordForgetLink.VisitedLinkColor = System.Drawing.Color.GreenYellow;
            this.PasswordForgetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordForgetLink_LinkClicked);
            // 
            // cashierPasstext
            // 
            this.cashierPasstext.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cashierPasstext.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cashierPasstext.Location = new System.Drawing.Point(108, 420);
            this.cashierPasstext.Name = "cashierPasstext";
            this.cashierPasstext.Size = new System.Drawing.Size(337, 33);
            this.cashierPasstext.TabIndex = 4;
            this.cashierPasstext.TextChanged += new System.EventHandler(this.cashierPasstext_TextChanged);
            this.cashierPasstext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashierPasstext_KeyPress);
            // 
            // cashierPassLabel
            // 
            this.cashierPassLabel.AutoSize = true;
            this.cashierPassLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cashierPassLabel.Location = new System.Drawing.Point(38, 377);
            this.cashierPassLabel.Name = "cashierPassLabel";
            this.cashierPassLabel.Size = new System.Drawing.Size(85, 42);
            this.cashierPassLabel.TabIndex = 3;
            this.cashierPassLabel.Text = "Şifre";
            // 
            // cashierIDLabel
            // 
            this.cashierIDLabel.AutoSize = true;
            this.cashierIDLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cashierIDLabel.Location = new System.Drawing.Point(38, 267);
            this.cashierIDLabel.Name = "cashierIDLabel";
            this.cashierIDLabel.Size = new System.Drawing.Size(232, 46);
            this.cashierIDLabel.TabIndex = 2;
            this.cashierIDLabel.Text = "Kullanıcı Adı";
            // 
            // CashierIdText
            // 
            this.CashierIdText.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CashierIdText.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CashierIdText.Location = new System.Drawing.Point(108, 322);
            this.CashierIdText.Name = "CashierIdText";
            this.CashierIdText.Size = new System.Drawing.Size(337, 33);
            this.CashierIdText.TabIndex = 1;
            this.CashierIdText.TextChanged += new System.EventHandler(this.CashierIdText_TextChanged);
            this.CashierIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashierIdText_KeyPress);
            // 
            // cashierPict
            // 
            this.cashierPict.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_cashier_64;
            this.cashierPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cashierPict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashierPict.Location = new System.Drawing.Point(148, 83);
            this.cashierPict.Name = "cashierPict";
            this.cashierPict.Size = new System.Drawing.Size(276, 160);
            this.cashierPict.TabIndex = 0;
            this.cashierPict.TabStop = false;
            // 
            // PictruePage
            // 
            this.PictruePage.BackColor = System.Drawing.Color.Transparent;
            this.PictruePage.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_restaurant_80;
            this.PictruePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictruePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictruePage.Location = new System.Drawing.Point(808, 297);
            this.PictruePage.Name = "PictruePage";
            this.PictruePage.Size = new System.Drawing.Size(286, 219);
            this.PictruePage.TabIndex = 2;
            this.PictruePage.TabStop = false;
            // 
            // waiterLoginGrpBox
            // 
            this.waiterLoginGrpBox.BackColor = System.Drawing.Color.Transparent;
            this.waiterLoginGrpBox.Controls.Add(this.WaitercheckBox);
            this.waiterLoginGrpBox.Controls.Add(this.waiterLoginButton);
            this.waiterLoginGrpBox.Controls.Add(this.WaiterForgotLinkLabel);
            this.waiterLoginGrpBox.Controls.Add(this.WaiterPassTxtBox);
            this.waiterLoginGrpBox.Controls.Add(this.waiterPassLabel);
            this.waiterLoginGrpBox.Controls.Add(this.WaiterIdTxtBox);
            this.waiterLoginGrpBox.Controls.Add(this.waiterIDlabel);
            this.waiterLoginGrpBox.Controls.Add(this.WaiterPict);
            this.waiterLoginGrpBox.Font = new System.Drawing.Font("Harlow Solid Italic", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.waiterLoginGrpBox.ForeColor = System.Drawing.Color.DarkRed;
            this.waiterLoginGrpBox.Location = new System.Drawing.Point(1196, 161);
            this.waiterLoginGrpBox.Name = "waiterLoginGrpBox";
            this.waiterLoginGrpBox.Size = new System.Drawing.Size(609, 617);
            this.waiterLoginGrpBox.TabIndex = 3;
            this.waiterLoginGrpBox.TabStop = false;
            this.waiterLoginGrpBox.Text = "Garson Girişi";
            // 
            // WaitercheckBox
            // 
            this.WaitercheckBox.AutoSize = true;
            this.WaitercheckBox.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WaitercheckBox.Location = new System.Drawing.Point(515, 420);
            this.WaitercheckBox.Name = "WaitercheckBox";
            this.WaitercheckBox.Size = new System.Drawing.Size(86, 29);
            this.WaitercheckBox.TabIndex = 7;
            this.WaitercheckBox.Text = "Göster";
            this.WaitercheckBox.UseVisualStyleBackColor = true;
            this.WaitercheckBox.CheckedChanged += new System.EventHandler(this.WaitercheckBox_CheckedChanged);
            // 
            // waiterLoginButton
            // 
            this.waiterLoginButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.waiterLoginButton.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.waiterLoginButton.Location = new System.Drawing.Point(433, 533);
            this.waiterLoginButton.Name = "waiterLoginButton";
            this.waiterLoginButton.Size = new System.Drawing.Size(158, 60);
            this.waiterLoginButton.TabIndex = 6;
            this.waiterLoginButton.Text = "Giriş";
            this.waiterLoginButton.UseVisualStyleBackColor = false;
            this.waiterLoginButton.Click += new System.EventHandler(this.waiterLoginButton_Click);
            // 
            // WaiterForgotLinkLabel
            // 
            this.WaiterForgotLinkLabel.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.WaiterForgotLinkLabel.AutoSize = true;
            this.WaiterForgotLinkLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WaiterForgotLinkLabel.LinkColor = System.Drawing.Color.DarkRed;
            this.WaiterForgotLinkLabel.Location = new System.Drawing.Point(21, 467);
            this.WaiterForgotLinkLabel.Name = "WaiterForgotLinkLabel";
            this.WaiterForgotLinkLabel.Size = new System.Drawing.Size(173, 29);
            this.WaiterForgotLinkLabel.TabIndex = 5;
            this.WaiterForgotLinkLabel.TabStop = true;
            this.WaiterForgotLinkLabel.Text = "Şifremi Unuttum";
            this.WaiterForgotLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // WaiterPassTxtBox
            // 
            this.WaiterPassTxtBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.WaiterPassTxtBox.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WaiterPassTxtBox.Location = new System.Drawing.Point(135, 420);
            this.WaiterPassTxtBox.Name = "WaiterPassTxtBox";
            this.WaiterPassTxtBox.Size = new System.Drawing.Size(350, 33);
            this.WaiterPassTxtBox.TabIndex = 4;
            this.WaiterPassTxtBox.TextChanged += new System.EventHandler(this.WaiterPassTxtBox_TextChanged);
            this.WaiterPassTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WaiterPassTxtBox_KeyPress);
            // 
            // waiterPassLabel
            // 
            this.waiterPassLabel.AutoSize = true;
            this.waiterPassLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.waiterPassLabel.Location = new System.Drawing.Point(21, 382);
            this.waiterPassLabel.Name = "waiterPassLabel";
            this.waiterPassLabel.Size = new System.Drawing.Size(71, 35);
            this.waiterPassLabel.TabIndex = 3;
            this.waiterPassLabel.Text = "Şifre";
            // 
            // WaiterIdTxtBox
            // 
            this.WaiterIdTxtBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.WaiterIdTxtBox.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WaiterIdTxtBox.Location = new System.Drawing.Point(135, 322);
            this.WaiterIdTxtBox.Name = "WaiterIdTxtBox";
            this.WaiterIdTxtBox.Size = new System.Drawing.Size(350, 33);
            this.WaiterIdTxtBox.TabIndex = 2;
            this.WaiterIdTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WaiterIdTxtBox_KeyPress);
            // 
            // waiterIDlabel
            // 
            this.waiterIDlabel.AutoSize = true;
            this.waiterIDlabel.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.waiterIDlabel.Location = new System.Drawing.Point(21, 267);
            this.waiterIDlabel.Name = "waiterIDlabel";
            this.waiterIDlabel.Size = new System.Drawing.Size(175, 35);
            this.waiterIDlabel.TabIndex = 1;
            this.waiterIDlabel.Text = "Kullanıcı Adı";
            // 
            // WaiterPict
            // 
            this.WaiterPict.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_waiter_64;
            this.WaiterPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WaiterPict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WaiterPict.Location = new System.Drawing.Point(165, 83);
            this.WaiterPict.Name = "WaiterPict";
            this.WaiterPict.Size = new System.Drawing.Size(276, 160);
            this.WaiterPict.TabIndex = 0;
            this.WaiterPict.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.SeaShell;
            this.ExitBtn.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_logout_rounded_100;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitBtn.Location = new System.Drawing.Point(1717, 957);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(135, 112);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp2.Properties.Resources.texture_g85699f4eb_1920;
            this.ClientSize = new System.Drawing.Size(1851, 1070);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.waiterLoginGrpBox);
            this.Controls.Add(this.PictruePage);
            this.Controls.Add(this.CashierLogingrpBx);
            this.Controls.Add(this.EmployeeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.CashierLogingrpBx.ResumeLayout(false);
            this.CashierLogingrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictruePage)).EndInit();
            this.waiterLoginGrpBox.ResumeLayout(false);
            this.waiterLoginGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaiterPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EmployeeText;
        private GroupBox CashierLogingrpBx;
        private CheckBox cashierCheckBox;
        private Button CashierLoginButton;
        private LinkLabel PasswordForgetLink;
        private TextBox cashierPasstext;
        private Label cashierPassLabel;
        private Label cashierIDLabel;
        private TextBox CashierIdText;
        private PictureBox cashierPict;
        private PictureBox PictruePage;
        private GroupBox waiterLoginGrpBox;
        private CheckBox WaitercheckBox;
        private Button waiterLoginButton;
        private LinkLabel WaiterForgotLinkLabel;
        private TextBox WaiterPassTxtBox;
        private Label waiterPassLabel;
        private TextBox WaiterIdTxtBox;
        private Label waiterIDlabel;
        private PictureBox WaiterPict;
        private Button ExitBtn;
    }
}