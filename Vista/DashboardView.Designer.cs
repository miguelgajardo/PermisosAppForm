namespace PermisosAppForm.Vista
{
    partial class DashboardView
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
            this.contribuyentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarContribuyentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contribuyentesToolStripMenuItem1,
            this.vehículosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contribuyentesToolStripMenuItem1
            // 
            this.contribuyentesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarContribuyentesToolStripMenuItem});
            this.contribuyentesToolStripMenuItem1.Name = "contribuyentesToolStripMenuItem1";
            this.contribuyentesToolStripMenuItem1.Size = new System.Drawing.Size(197, 36);
            this.contribuyentesToolStripMenuItem1.Text = "Contribuyentes";
            // 
            // listarContribuyentesToolStripMenuItem
            // 
            this.listarContribuyentesToolStripMenuItem.Name = "listarContribuyentesToolStripMenuItem";
            this.listarContribuyentesToolStripMenuItem.Size = new System.Drawing.Size(418, 44);
            this.listarContribuyentesToolStripMenuItem.Text = "Gestionar Contribuyentes";
            this.listarContribuyentesToolStripMenuItem.Click += new System.EventHandler(this.listarContribuyentesToolStripMenuItem_Click);
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVehículosToolStripMenuItem});
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(135, 38);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            // 
            // listarVehículosToolStripMenuItem
            // 
            this.listarVehículosToolStripMenuItem.Name = "listarVehículosToolStripMenuItem";
            this.listarVehículosToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.listarVehículosToolStripMenuItem.Text = "Listar Vehículos";
            this.listarVehículosToolStripMenuItem.Click += new System.EventHandler(this.listarVehículosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(79, 38);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardView";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.DashboardView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contribuyentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarContribuyentesToolStripMenuItem;
    }
}