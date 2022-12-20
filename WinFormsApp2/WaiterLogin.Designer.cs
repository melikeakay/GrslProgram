namespace WinFormsApp2
{
    partial class WaiterLogin
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
            this.MasaBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.CıkısBtn = new System.Windows.Forms.Button();
            this.LockBtn = new System.Windows.Forms.Button();
            this.RaporBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MasaBtn
            // 
            this.MasaBtn.BackColor = System.Drawing.Color.SeaShell;
            this.MasaBtn.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_restaurant_table_100;
            this.MasaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MasaBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MasaBtn.ForeColor = System.Drawing.Color.Tomato;
            this.MasaBtn.Location = new System.Drawing.Point(179, 247);
            this.MasaBtn.Name = "MasaBtn";
            this.MasaBtn.Size = new System.Drawing.Size(424, 347);
            this.MasaBtn.TabIndex = 0;
            this.MasaBtn.Text = "Masalar";
            this.MasaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MasaBtn.UseVisualStyleBackColor = false;
            this.MasaBtn.Click += new System.EventHandler(this.MasaBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.SeaShell;
            this.MenuBtn.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_menu_64;
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MenuBtn.ForeColor = System.Drawing.Color.Tomato;
            this.MenuBtn.Location = new System.Drawing.Point(786, 247);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(424, 347);
            this.MenuBtn.TabIndex = 1;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // CıkısBtn
            // 
            this.CıkısBtn.BackColor = System.Drawing.Color.SeaShell;
            this.CıkısBtn.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_logout_100;
            this.CıkısBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CıkısBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CıkısBtn.ForeColor = System.Drawing.Color.Tomato;
            this.CıkısBtn.Location = new System.Drawing.Point(1124, 662);
            this.CıkısBtn.Name = "CıkısBtn";
            this.CıkısBtn.Size = new System.Drawing.Size(424, 347);
            this.CıkısBtn.TabIndex = 2;
            this.CıkısBtn.Text = "Çıkış";
            this.CıkısBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CıkısBtn.UseVisualStyleBackColor = false;
            this.CıkısBtn.Click += new System.EventHandler(this.CıkısBtn_Click);
            // 
            // LockBtn
            // 
            this.LockBtn.BackColor = System.Drawing.Color.SeaShell;
            this.LockBtn.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_lock_50;
            this.LockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LockBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LockBtn.ForeColor = System.Drawing.Color.Tomato;
            this.LockBtn.Location = new System.Drawing.Point(449, 662);
            this.LockBtn.Name = "LockBtn";
            this.LockBtn.Size = new System.Drawing.Size(424, 347);
            this.LockBtn.TabIndex = 3;
            this.LockBtn.Text = "Kilitle";
            this.LockBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LockBtn.UseVisualStyleBackColor = false;
            this.LockBtn.Click += new System.EventHandler(this.LockBtn_Click);
            // 
            // RaporBtn
            // 
            this.RaporBtn.BackColor = System.Drawing.Color.SeaShell;
            this.RaporBtn.BackgroundImage = global::WinFormsApp2.Properties.Resources.icons8_report_64;
            this.RaporBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RaporBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RaporBtn.ForeColor = System.Drawing.Color.Tomato;
            this.RaporBtn.Location = new System.Drawing.Point(1386, 247);
            this.RaporBtn.Name = "RaporBtn";
            this.RaporBtn.Size = new System.Drawing.Size(424, 347);
            this.RaporBtn.TabIndex = 4;
            this.RaporBtn.Text = "Raporlar";
            this.RaporBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RaporBtn.UseVisualStyleBackColor = false;
            this.RaporBtn.Click += new System.EventHandler(this.RaporBtn_Click);
            // 
            // WaiterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.RaporBtn);
            this.Controls.Add(this.LockBtn);
            this.Controls.Add(this.CıkısBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.MasaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaiterLogin";
            this.Text = "WaiterLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button MasaBtn;
        private Button MenuBtn;
        private Button CıkısBtn;
        private Button LockBtn;
        private Button RaporBtn;
    }
}