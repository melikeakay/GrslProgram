namespace WinFormsApp2
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManagerPict = new System.Windows.Forms.PictureBox();
            this.EmployeePict = new System.Windows.Forms.PictureBox();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePict)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerPict
            // 
            this.ManagerPict.BackColor = System.Drawing.Color.Transparent;
            this.ManagerPict.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_businessman_100;
            this.ManagerPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManagerPict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManagerPict.Location = new System.Drawing.Point(125, 367);
            this.ManagerPict.Name = "ManagerPict";
            this.ManagerPict.Size = new System.Drawing.Size(383, 211);
            this.ManagerPict.TabIndex = 0;
            this.ManagerPict.TabStop = false;
            // 
            // EmployeePict
            // 
            this.EmployeePict.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePict.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_waiter_100;
            this.EmployeePict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EmployeePict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeePict.Location = new System.Drawing.Point(1307, 367);
            this.EmployeePict.Name = "EmployeePict";
            this.EmployeePict.Size = new System.Drawing.Size(289, 225);
            this.EmployeePict.TabIndex = 1;
            this.EmployeePict.TabStop = false;
            // 
            // ManagerButton
            // 
            this.ManagerButton.BackColor = System.Drawing.Color.DarkGray;
            this.ManagerButton.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ManagerButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ManagerButton.Location = new System.Drawing.Point(90, 623);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(446, 111);
            this.ManagerButton.TabIndex = 2;
            this.ManagerButton.Text = "Yönetici Girişi";
            this.ManagerButton.UseVisualStyleBackColor = false;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.DarkGray;
            this.EmployeeButton.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EmployeeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EmployeeButton.Location = new System.Drawing.Point(1205, 623);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(444, 111);
            this.EmployeeButton.TabIndex = 3;
            this.EmployeeButton.Text = "Çalışan Girişi";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ExitButton.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_logout_rounded_64;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Location = new System.Drawing.Point(1629, 963);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 88);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp2.Properties.Resources.wooden_gabb9b2a0e_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1771, 1063);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.EmployeePict);
            this.Controls.Add(this.ManagerPict);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ManagerPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ManagerPict;
        private PictureBox EmployeePict;
        private Button ManagerButton;
        private Button EmployeeButton;
        private Button ExitButton;
    }
}