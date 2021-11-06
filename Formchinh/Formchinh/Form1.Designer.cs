namespace Formchinh
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TàiKhoảnToolStripMenuItem,
            this.QuảnLýKháchHàngToolStripMenuItem,
            this.HoáĐơnToolStripMenuItem,
            this.KhoHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TàiKhoảnToolStripMenuItem
            // 
            this.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem";
            this.TàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.TàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.TàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // QuảnLýKháchHàngToolStripMenuItem
            // 
            this.QuảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinKháchHàngToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem";
            this.QuảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            // 
            // HoáĐơnToolStripMenuItem
            // 
            this.HoáĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHoáĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.HoáĐơnToolStripMenuItem.Name = "HoáĐơnToolStripMenuItem";
            this.HoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.HoáĐơnToolStripMenuItem.Text = "Hoá Đơn";
            // 
            // chiTiếtHoáĐơnToolStripMenuItem
            // 
            this.chiTiếtHoáĐơnToolStripMenuItem.Name = "chiTiếtHoáĐơnToolStripMenuItem";
            this.chiTiếtHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.chiTiếtHoáĐơnToolStripMenuItem.Text = "Chi Tiết Hoá đơn";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // sửaThôngTinKháchHàngToolStripMenuItem
            // 
            this.sửaThôngTinKháchHàngToolStripMenuItem.Name = "sửaThôngTinKháchHàngToolStripMenuItem";
            this.sửaThôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sửaThôngTinKháchHàngToolStripMenuItem.Text = "Sửa thông tin khách hàng";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // KhoHàngToolStripMenuItem
            // 
            this.KhoHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HàngToolStripMenuItem});
            this.KhoHàngToolStripMenuItem.Name = "KhoHàngToolStripMenuItem";
            this.KhoHàngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.KhoHàngToolStripMenuItem.Text = "Kho Hàng";
            // 
            // HàngToolStripMenuItem
            // 
            this.HàngToolStripMenuItem.Name = "HàngToolStripMenuItem";
            this.HàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HàngToolStripMenuItem.Text = "Hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 358);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HàngToolStripMenuItem;
    }
}

