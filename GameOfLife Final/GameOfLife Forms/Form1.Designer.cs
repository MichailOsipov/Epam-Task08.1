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
			this.panelGameField = new System.Windows.Forms.Panel();
			this.textBoxSaveMessager = new System.Windows.Forms.TextBox();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.buttonInput = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.standartModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.algorithm42ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mixedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.animalsModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
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
			this.textBoxLog.Size = new System.Drawing.Size(318, 32);
			this.textBoxLog.TabIndex = 3;
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(30, 391);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(165, 20);
			this.textBoxInput.TabIndex = 4;
			// 
			// buttonInput
			// 
			this.buttonInput.Location = new System.Drawing.Point(229, 391);
			this.buttonInput.Name = "buttonInput";
			this.buttonInput.Size = new System.Drawing.Size(119, 20);
			this.buttonInput.TabIndex = 5;
			this.buttonInput.Text = "ОК";
			this.buttonInput.UseVisualStyleBackColor = true;
			this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(814, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gameToolStripMenuItem
			// 
			this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.viewSavesToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.removeGameToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.gameToolStripMenuItem.Text = "Game";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartModeToolStripMenuItem,
            this.algorithm42ToolStripMenuItem,
            this.mixedModeToolStripMenuItem,
            this.animalsModeToolStripMenuItem});
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.newGameToolStripMenuItem.Text = "New game";
			// 
			// standartModeToolStripMenuItem
			// 
			this.standartModeToolStripMenuItem.Name = "standartModeToolStripMenuItem";
			this.standartModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.standartModeToolStripMenuItem.Text = "Standart mode";
			this.standartModeToolStripMenuItem.Click += new System.EventHandler(this.standartModeToolStripMenuItem_Click);
			// 
			// algorithm42ToolStripMenuItem
			// 
			this.algorithm42ToolStripMenuItem.Name = "algorithm42ToolStripMenuItem";
			this.algorithm42ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.algorithm42ToolStripMenuItem.Text = "Algorithm 4.2";
			this.algorithm42ToolStripMenuItem.Click += new System.EventHandler(this.algorithm42ToolStripMenuItem_Click);
			// 
			// mixedModeToolStripMenuItem
			// 
			this.mixedModeToolStripMenuItem.Name = "mixedModeToolStripMenuItem";
			this.mixedModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.mixedModeToolStripMenuItem.Text = "Mixed mode";
			this.mixedModeToolStripMenuItem.Click += new System.EventHandler(this.mixedModeToolStripMenuItem_Click);
			// 
			// animalsModeToolStripMenuItem
			// 
			this.animalsModeToolStripMenuItem.Name = "animalsModeToolStripMenuItem";
			this.animalsModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.animalsModeToolStripMenuItem.Text = "Animals mode";
			this.animalsModeToolStripMenuItem.Click += new System.EventHandler(this.animalsModeToolStripMenuItem_Click);
			// 
			// viewSavesToolStripMenuItem
			// 
			this.viewSavesToolStripMenuItem.Name = "viewSavesToolStripMenuItem";
			this.viewSavesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.viewSavesToolStripMenuItem.Text = "View saves";
			this.viewSavesToolStripMenuItem.Click += new System.EventHandler(this.viewSavesToolStripMenuItem_Click);
			// 
			// saveGameToolStripMenuItem
			// 
			this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
			this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.saveGameToolStripMenuItem.Text = "Save game";
			this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
			// 
			// loadGameToolStripMenuItem
			// 
			this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
			this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.loadGameToolStripMenuItem.Text = "Load game";
			this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
			// 
			// removeGameToolStripMenuItem
			// 
			this.removeGameToolStripMenuItem.Name = "removeGameToolStripMenuItem";
			this.removeGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.removeGameToolStripMenuItem.Text = "Remove game";
			this.removeGameToolStripMenuItem.Click += new System.EventHandler(this.removeGameToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 467);
			this.Controls.Add(this.buttonInput);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.textBoxSaveMessager);
			this.Controls.Add(this.panelGameField);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Game about life of animals and grass";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelGameField;
		private System.Windows.Forms.TextBox textBoxSaveMessager;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Button buttonInput;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem standartModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem algorithm42ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mixedModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem animalsModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewSavesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

