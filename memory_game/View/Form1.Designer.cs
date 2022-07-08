
namespace memory_game
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame4ToolStripMenuItem,
            this.newGame8ToolStripMenuItem,
            this.newGame16ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGame4ToolStripMenuItem
            // 
            this.newGame4ToolStripMenuItem.Name = "newGame4ToolStripMenuItem";
            this.newGame4ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newGame4ToolStripMenuItem.Text = "New Game 4";
            this.newGame4ToolStripMenuItem.Click += new System.EventHandler(this.NewGameFour);
            // 
            // newGame8ToolStripMenuItem
            // 
            this.newGame8ToolStripMenuItem.Name = "newGame8ToolStripMenuItem";
            this.newGame8ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newGame8ToolStripMenuItem.Text = "New Game 8";
            this.newGame8ToolStripMenuItem.Click += new System.EventHandler(this.NewGameEight);
            // 
            // newGame16ToolStripMenuItem
            // 
            this.newGame16ToolStripMenuItem.Name = "newGame16ToolStripMenuItem";
            this.newGame16ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newGame16ToolStripMenuItem.Text = "New Game 16";
            this.newGame16ToolStripMenuItem.Click += new System.EventHandler(this.NewGameSixTeen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "memory_game";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame16ToolStripMenuItem;
    }
}

