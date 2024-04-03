namespace uhr
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
            this.clock1 = new uhr.clock();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветЦиферблатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветСтрелокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЧасовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветМинутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветСекундToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clock2 = new uhr.clock();
            this.clock3 = new uhr.clock();
            this.clock4 = new uhr.clock();
            this.clock5 = new uhr.clock();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.ClockColor = System.Drawing.Color.Black;
            this.clock1.hColor = System.Drawing.Color.Black;
            this.clock1.Location = new System.Drawing.Point(12, 35);
            this.clock1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clock1.mColor = System.Drawing.Color.Black;
            this.clock1.Name = "clock1";
            this.clock1.sColor = System.Drawing.Color.Black;
            this.clock1.Size = new System.Drawing.Size(255, 221);
            this.clock1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветЦиферблатаToolStripMenuItem,
            this.цветСтрелокToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сброситьЦветаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветЦиферблатаToolStripMenuItem
            // 
            this.цветЦиферблатаToolStripMenuItem.Name = "цветЦиферблатаToolStripMenuItem";
            this.цветЦиферблатаToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.цветЦиферблатаToolStripMenuItem.Text = "Цвет циферблата";
            this.цветЦиферблатаToolStripMenuItem.Click += new System.EventHandler(this.цветЦиферблатаToolStripMenuItem_Click);
            // 
            // цветСтрелокToolStripMenuItem
            // 
            this.цветСтрелокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветЧасовToolStripMenuItem,
            this.цветМинутToolStripMenuItem,
            this.цветСекундToolStripMenuItem});
            this.цветСтрелокToolStripMenuItem.Name = "цветСтрелокToolStripMenuItem";
            this.цветСтрелокToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.цветСтрелокToolStripMenuItem.Text = "Цвет стрелок";
            // 
            // цветЧасовToolStripMenuItem
            // 
            this.цветЧасовToolStripMenuItem.Name = "цветЧасовToolStripMenuItem";
            this.цветЧасовToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.цветЧасовToolStripMenuItem.Text = "Цвет часов";
            this.цветЧасовToolStripMenuItem.Click += new System.EventHandler(this.цветЧасовToolStripMenuItem_Click);
            // 
            // цветМинутToolStripMenuItem
            // 
            this.цветМинутToolStripMenuItem.Name = "цветМинутToolStripMenuItem";
            this.цветМинутToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.цветМинутToolStripMenuItem.Text = "Цвет минут";
            this.цветМинутToolStripMenuItem.Click += new System.EventHandler(this.цветМинутToolStripMenuItem_Click);
            // 
            // цветСекундToolStripMenuItem
            // 
            this.цветСекундToolStripMenuItem.Name = "цветСекундToolStripMenuItem";
            this.цветСекундToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.цветСекундToolStripMenuItem.Text = "Цвет секунд";
            this.цветСекундToolStripMenuItem.Click += new System.EventHandler(this.цветСекундToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // сброситьЦветаToolStripMenuItem
            // 
            this.сброситьЦветаToolStripMenuItem.Name = "сброситьЦветаToolStripMenuItem";
            this.сброситьЦветаToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.сброситьЦветаToolStripMenuItem.Text = "Сбросить цвета";
            this.сброситьЦветаToolStripMenuItem.Click += new System.EventHandler(this.сброситьЦветаToolStripMenuItem_Click);
            // 
            // clock2
            // 
            this.clock2.ClockColor = System.Drawing.Color.Black;
            this.clock2.hColor = System.Drawing.Color.Black;
            this.clock2.Location = new System.Drawing.Point(273, 51);
            this.clock2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clock2.mColor = System.Drawing.Color.Black;
            this.clock2.Name = "clock2";
            this.clock2.sColor = System.Drawing.Color.Black;
            this.clock2.Size = new System.Drawing.Size(145, 131);
            this.clock2.TabIndex = 2;
            // 
            // clock3
            // 
            this.clock3.ClockColor = System.Drawing.Color.Black;
            this.clock3.hColor = System.Drawing.Color.Black;
            this.clock3.Location = new System.Drawing.Point(429, 51);
            this.clock3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clock3.mColor = System.Drawing.Color.Black;
            this.clock3.Name = "clock3";
            this.clock3.sColor = System.Drawing.Color.Black;
            this.clock3.Size = new System.Drawing.Size(404, 379);
            this.clock3.TabIndex = 3;
            // 
            // clock4
            // 
            this.clock4.ClockColor = System.Drawing.Color.Black;
            this.clock4.hColor = System.Drawing.Color.Black;
            this.clock4.Location = new System.Drawing.Point(59, 266);
            this.clock4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clock4.mColor = System.Drawing.Color.Black;
            this.clock4.Name = "clock4";
            this.clock4.sColor = System.Drawing.Color.Black;
            this.clock4.Size = new System.Drawing.Size(162, 161);
            this.clock4.TabIndex = 4;
            // 
            // clock5
            // 
            this.clock5.ClockColor = System.Drawing.Color.Black;
            this.clock5.hColor = System.Drawing.Color.Black;
            this.clock5.Location = new System.Drawing.Point(227, 368);
            this.clock5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clock5.mColor = System.Drawing.Color.Black;
            this.clock5.Name = "clock5";
            this.clock5.sColor = System.Drawing.Color.Black;
            this.clock5.Size = new System.Drawing.Size(263, 244);
            this.clock5.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 1015);
            this.Controls.Add(this.clock5);
            this.Controls.Add(this.clock4);
            this.Controls.Add(this.clock3);
            this.Controls.Add(this.clock2);
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private clock clock1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цветЦиферблатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветСтрелокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЧасовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветМинутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветСекундToolStripMenuItem;
        private clock clock2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сброситьЦветаToolStripMenuItem;
        private clock clock3;
        private clock clock4;
        private clock clock5;
    }
}
