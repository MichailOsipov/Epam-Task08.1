namespace GameOfLife_Forms
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
			this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.стандартныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.режимПоАлгоритму42ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.смешанныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.режимСЖивотнымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.посмотретьСохраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelGameField = new System.Windows.Forms.Panel();
			this.textBoxSaveMessager = new System.Windows.Forms.TextBox();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(872, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// играToolStripMenuItem
			// 
			this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.посмотретьСохраненияToolStripMenuItem,
            this.сохранитьИгруToolStripMenuItem,
            this.загрузитьИгруToolStripMenuItem,
            this.удалитьИгруToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.играToolStripMenuItem.Name = "играToolStripMenuItem";
			this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.играToolStripMenuItem.Text = "Игра";
			// 
			// новаяИграToolStripMenuItem
			// 
			this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныйРежимToolStripMenuItem,
            this.режимПоАлгоритму42ToolStripMenuItem,
            this.смешанныйРежимToolStripMenuItem,
            this.режимСЖивотнымиToolStripMenuItem});
			this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
			this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.новаяИграToolStripMenuItem.Text = "Новая игра";
			// 
			// стандартныйРежимToolStripMenuItem
			// 
			this.стандартныйРежимToolStripMenuItem.Name = "стандартныйРежимToolStripMenuItem";
			this.стандартныйРежимToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.стандартныйРежимToolStripMenuItem.Text = "Стандартный режим";
			this.стандартныйРежимToolStripMenuItem.Click += new System.EventHandler(this.стандартныйРежимToolStripMenuItem_Click);
			// 
			// режимПоАлгоритму42ToolStripMenuItem
			// 
			this.режимПоАлгоритму42ToolStripMenuItem.Name = "режимПоАлгоритму42ToolStripMenuItem";
			this.режимПоАлгоритму42ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.режимПоАлгоритму42ToolStripMenuItem.Text = "Режим по алгоритму 4.2";
			this.режимПоАлгоритму42ToolStripMenuItem.Click += new System.EventHandler(this.режимПоАлгоритму42ToolStripMenuItem_Click);
			// 
			// смешанныйРежимToolStripMenuItem
			// 
			this.смешанныйРежимToolStripMenuItem.Name = "смешанныйРежимToolStripMenuItem";
			this.смешанныйРежимToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.смешанныйРежимToolStripMenuItem.Text = "Смешанный режим";
			this.смешанныйРежимToolStripMenuItem.Click += new System.EventHandler(this.смешанныйРежимToolStripMenuItem_Click);
			// 
			// режимСЖивотнымиToolStripMenuItem
			// 
			this.режимСЖивотнымиToolStripMenuItem.Name = "режимСЖивотнымиToolStripMenuItem";
			this.режимСЖивотнымиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.режимСЖивотнымиToolStripMenuItem.Text = "Режим с животными";
			this.режимСЖивотнымиToolStripMenuItem.Click += new System.EventHandler(this.режимСЖивотнымиToolStripMenuItem_Click);
			// 
			// посмотретьСохраненияToolStripMenuItem
			// 
			this.посмотретьСохраненияToolStripMenuItem.Name = "посмотретьСохраненияToolStripMenuItem";
			this.посмотретьСохраненияToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.посмотретьСохраненияToolStripMenuItem.Text = "Посмотреть сохранения";
			this.посмотретьСохраненияToolStripMenuItem.Click += new System.EventHandler(this.посмотретьСохраненияToolStripMenuItem_Click);
			// 
			// сохранитьИгруToolStripMenuItem
			// 
			this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
			this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру";
			this.сохранитьИгруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИгруToolStripMenuItem_Click);
			// 
			// загрузитьИгруToolStripMenuItem
			// 
			this.загрузитьИгруToolStripMenuItem.Name = "загрузитьИгруToolStripMenuItem";
			this.загрузитьИгруToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.загрузитьИгруToolStripMenuItem.Text = "Загрузить игру";
			this.загрузитьИгруToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИгруToolStripMenuItem_Click);
			// 
			// удалитьИгруToolStripMenuItem
			// 
			this.удалитьИгруToolStripMenuItem.Name = "удалитьИгруToolStripMenuItem";
			this.удалитьИгруToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.удалитьИгруToolStripMenuItem.Text = "Удалить игру";
			this.удалитьИгруToolStripMenuItem.Click += new System.EventHandler(this.удалитьИгруToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// panelGameField
			// 
			this.panelGameField.Location = new System.Drawing.Point(377, 27);
			this.panelGameField.Name = "panelGameField";
			this.panelGameField.Size = new System.Drawing.Size(405, 347);
			this.panelGameField.TabIndex = 1;
			// 
			// textBoxSaveMessager
			// 
			this.textBoxSaveMessager.Location = new System.Drawing.Point(30, 94);
			this.textBoxSaveMessager.Multiline = true;
			this.textBoxSaveMessager.Name = "textBoxSaveMessager";
			this.textBoxSaveMessager.ReadOnly = true;
			this.textBoxSaveMessager.Size = new System.Drawing.Size(318, 280);
			this.textBoxSaveMessager.TabIndex = 2;
			// 
			// textBoxLog
			// 
			this.textBoxLog.Location = new System.Drawing.Point(30, 47);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(317, 32);
			this.textBoxLog.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 467);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.textBoxSaveMessager);
			this.Controls.Add(this.panelGameField);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Game about life of animals and grass";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загрузитьИгруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьИгруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem стандартныйРежимToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem режимПоАлгоритму42ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem смешанныйРежимToolStripMenuItem;
		private System.Windows.Forms.Panel panelGameField;
		private System.Windows.Forms.ToolStripMenuItem режимСЖивотнымиToolStripMenuItem;
		private System.Windows.Forms.TextBox textBoxSaveMessager;
		private System.Windows.Forms.ToolStripMenuItem посмотретьСохраненияToolStripMenuItem;
		private System.Windows.Forms.TextBox textBoxLog;
	}
}

