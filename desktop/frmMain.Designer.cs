namespace desktop
{
	partial class frmMain
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
			txtMain = new TextBox();
			btnCheckSpell = new Button();
			SuspendLayout();
			// 
			// txtMain
			// 
			txtMain.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtMain.Location = new Point(12, 54);
			txtMain.Multiline = true;
			txtMain.Name = "txtMain";
			txtMain.ScrollBars = ScrollBars.Vertical;
			txtMain.Size = new Size(776, 384);
			txtMain.TabIndex = 0;
			// 
			// btnCheckSpell
			// 
			btnCheckSpell.Location = new Point(674, 12);
			btnCheckSpell.Name = "btnCheckSpell";
			btnCheckSpell.Size = new Size(114, 36);
			btnCheckSpell.TabIndex = 1;
			btnCheckSpell.Text = "Check Spell";
			btnCheckSpell.UseVisualStyleBackColor = true;
			btnCheckSpell.Click += btnCheckSpell_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnCheckSpell);
			Controls.Add(txtMain);
			Name = "frmMain";
			Text = "Spell Checker";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtMain;
		private Button btnCheckSpell;
	}
}