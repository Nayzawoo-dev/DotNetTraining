namespace DotNetTraining
{
    partial class Product
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
            menuStrip1 = new MenuStrip();
            setUpToolStripMenuItem = new ToolStripMenuItem();
            productListAndSaveToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { setUpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(793, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // setUpToolStripMenuItem
            // 
            setUpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productListAndSaveToolStripMenuItem });
            setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            setUpToolStripMenuItem.Size = new Size(63, 24);
            setUpToolStripMenuItem.Text = "SetUp";
            // 
            // productListAndSaveToolStripMenuItem
            // 
            productListAndSaveToolStripMenuItem.Name = "productListAndSaveToolStripMenuItem";
            productListAndSaveToolStripMenuItem.Size = new Size(235, 26);
            productListAndSaveToolStripMenuItem.Text = "Product List And Save";
            productListAndSaveToolStripMenuItem.Click += productListAndSaveToolStripMenuItem_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 564);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            WindowState = FormWindowState.Maximized;
            Load += Product_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem setUpToolStripMenuItem;
        private ToolStripMenuItem productListAndSaveToolStripMenuItem;
    }
}