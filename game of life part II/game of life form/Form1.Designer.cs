namespace game_of_life_form
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
			this.textBoxTest = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxThreadTest = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.mixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxTest
			// 
			this.textBoxTest.Location = new System.Drawing.Point(96, 90);
			this.textBoxTest.Name = "textBoxTest";
			this.textBoxTest.Size = new System.Drawing.Size(100, 20);
			this.textBoxTest.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(111, 144);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxThreadTest
			// 
			this.textBoxThreadTest.Location = new System.Drawing.Point(96, 40);
			this.textBoxThreadTest.Name = "textBoxThreadTest";
			this.textBoxThreadTest.Size = new System.Drawing.Size(100, 20);
			this.textBoxThreadTest.TabIndex = 2;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(918, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// играToolStripMenuItem
			// 
			this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.сохранитьИгруToolStripMenuItem,
            this.загрузитьИгруToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.играToolStripMenuItem.Name = "играToolStripMenuItem";
			this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.играToolStripMenuItem.Text = "Игра";
			// 
			// новаяИграToolStripMenuItem
			// 
			this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.mixToolStripMenuItem});
			this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
			this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.новаяИграToolStripMenuItem.Text = "Новая игра";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 22);
			this.toolStripMenuItem2.Text = "4.1";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(93, 22);
			this.toolStripMenuItem3.Text = "4.2";
			// 
			// mixToolStripMenuItem
			// 
			this.mixToolStripMenuItem.Name = "mixToolStripMenuItem";
			this.mixToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.mixToolStripMenuItem.Text = "Mix";
			// 
			// сохранитьИгруToolStripMenuItem
			// 
			this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
			this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру";
			// 
			// загрузитьИгруToolStripMenuItem
			// 
			this.загрузитьИгруToolStripMenuItem.Name = "загрузитьИгруToolStripMenuItem";
			this.загрузитьИгруToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.загрузитьИгруToolStripMenuItem.Text = "Загрузить игру";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(311, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(449, 314);
			this.panel1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 582);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBoxThreadTest);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxTest);
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

		private System.Windows.Forms.TextBox textBoxTest;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxThreadTest;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mixToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загрузитьИгруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
	}
}

