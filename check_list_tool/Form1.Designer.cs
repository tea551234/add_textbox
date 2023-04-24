namespace check_list_tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.讀取CSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.讀取CSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清除CSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.讀取CSVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 讀取CSVToolStripMenuItem
            // 
            this.讀取CSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.讀取CSVToolStripMenuItem1,
            this.清除CSVToolStripMenuItem1});
            this.讀取CSVToolStripMenuItem.Name = "讀取CSVToolStripMenuItem";
            this.讀取CSVToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.讀取CSVToolStripMenuItem.Text = "CSV相關";
            // 
            // 讀取CSVToolStripMenuItem1
            // 
            this.讀取CSVToolStripMenuItem1.Name = "讀取CSVToolStripMenuItem1";
            this.讀取CSVToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.讀取CSVToolStripMenuItem1.Text = "讀取CSV";
            this.讀取CSVToolStripMenuItem1.Click += new System.EventHandler(this.讀取CSVToolStripMenuItem1_Click);
            // 
            // 清除CSVToolStripMenuItem1
            // 
            this.清除CSVToolStripMenuItem1.Name = "清除CSVToolStripMenuItem1";
            this.清除CSVToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.清除CSVToolStripMenuItem1.Text = "清除CSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(806, 312);
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
        private System.Windows.Forms.ToolStripMenuItem 讀取CSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 讀取CSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清除CSVToolStripMenuItem1;
    }
}

