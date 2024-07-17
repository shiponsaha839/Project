namespace desktop
{
	partial class frmSpellChecker
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
			txtInput = new RichTextBox();
			label1 = new Label();
			label2 = new Label();
			txtIncorrect = new TextBox();
			txtReplace = new TextBox();
			lbSuggestion = new ListBox();
			label3 = new Label();
			btnIgnore = new Button();
			btnIgnoreAll = new Button();
			btnChangeAll = new Button();
			btnChange = new Button();
			btnSearch = new Button();
			btnIgnoreWords = new Button();
			btnAddAutoCorrect = new Button();
			btnAddWord = new Button();
			btnClose = new Button();
			SuspendLayout();
			// 
			// txtInput
			// 
			txtInput.Location = new Point(-1, 0);
			txtInput.Name = "txtInput";
			txtInput.ReadOnly = true;
			txtInput.ScrollBars = RichTextBoxScrollBars.Vertical;
			txtInput.Size = new Size(252, 152);
			txtInput.TabIndex = 1;
			txtInput.Text = "";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(-1, 155);
			label1.Name = "label1";
			label1.Size = new Size(100, 15);
			label1.TabIndex = 2;
			label1.Text = "Not In Dictionary:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(-1, 207);
			label2.Name = "label2";
			label2.Size = new Size(79, 15);
			label2.TabIndex = 3;
			label2.Text = "Replace With:";
			// 
			// txtIncorrect
			// 
			txtIncorrect.BackColor = Color.LightCoral;
			txtIncorrect.Location = new Point(-1, 173);
			txtIncorrect.Name = "txtIncorrect";
			txtIncorrect.Size = new Size(131, 23);
			txtIncorrect.TabIndex = 4;
			// 
			// txtReplace
			// 
			txtReplace.Location = new Point(-1, 225);
			txtReplace.Name = "txtReplace";
			txtReplace.Size = new Size(131, 23);
			txtReplace.TabIndex = 5;
			txtReplace.TextChanged += txtReplace_TextChanged;
			// 
			// lbSuggestion
			// 
			lbSuggestion.FormattingEnabled = true;
			lbSuggestion.ItemHeight = 15;
			lbSuggestion.Location = new Point(-1, 270);
			lbSuggestion.Name = "lbSuggestion";
			lbSuggestion.Size = new Size(131, 124);
			lbSuggestion.TabIndex = 6;
			lbSuggestion.SelectedIndexChanged += lbSuggestion_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(-1, 252);
			label3.Name = "label3";
			label3.Size = new Size(74, 15);
			label3.TabIndex = 7;
			label3.Text = "Suggestions:";
			// 
			// btnIgnore
			// 
			btnIgnore.Location = new Point(136, 159);
			btnIgnore.Name = "btnIgnore";
			btnIgnore.Size = new Size(115, 23);
			btnIgnore.TabIndex = 8;
			btnIgnore.Text = "Ignore";
			btnIgnore.UseVisualStyleBackColor = true;
			btnIgnore.Click += btnIgnore_Click;
			// 
			// btnIgnoreAll
			// 
			btnIgnoreAll.Location = new Point(136, 178);
			btnIgnoreAll.Name = "btnIgnoreAll";
			btnIgnoreAll.Size = new Size(115, 23);
			btnIgnoreAll.TabIndex = 9;
			btnIgnoreAll.Text = "Ignore All";
			btnIgnoreAll.UseVisualStyleBackColor = true;
			// 
			// btnChangeAll
			// 
			btnChangeAll.Enabled = false;
			btnChangeAll.Location = new Point(136, 230);
			btnChangeAll.Name = "btnChangeAll";
			btnChangeAll.Size = new Size(115, 23);
			btnChangeAll.TabIndex = 11;
			btnChangeAll.Text = "Change All";
			btnChangeAll.UseVisualStyleBackColor = true;
			btnChangeAll.Click += btnChangeAll_Click;
			// 
			// btnChange
			// 
			btnChange.Enabled = false;
			btnChange.Location = new Point(136, 211);
			btnChange.Name = "btnChange";
			btnChange.Size = new Size(115, 23);
			btnChange.TabIndex = 14;
			btnChange.Text = "Change";
			btnChange.UseVisualStyleBackColor = true;
			btnChange.Click += btnChange_Click;
			// 
			// btnSearch
			// 
			btnSearch.Enabled = false;
			btnSearch.Location = new Point(136, 319);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(115, 23);
			btnSearch.TabIndex = 18;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnIgnoreWords
			// 
			btnIgnoreWords.Enabled = false;
			btnIgnoreWords.Location = new Point(136, 338);
			btnIgnoreWords.Name = "btnIgnoreWords";
			btnIgnoreWords.Size = new Size(115, 23);
			btnIgnoreWords.TabIndex = 17;
			btnIgnoreWords.Text = "Ignore Words";
			btnIgnoreWords.UseVisualStyleBackColor = true;
			// 
			// btnAddAutoCorrect
			// 
			btnAddAutoCorrect.Enabled = false;
			btnAddAutoCorrect.Location = new Point(136, 286);
			btnAddAutoCorrect.Name = "btnAddAutoCorrect";
			btnAddAutoCorrect.Size = new Size(115, 23);
			btnAddAutoCorrect.TabIndex = 16;
			btnAddAutoCorrect.Text = "Add AutoCorrect";
			btnAddAutoCorrect.UseVisualStyleBackColor = true;
			// 
			// btnAddWord
			// 
			btnAddWord.Location = new Point(136, 267);
			btnAddWord.Name = "btnAddWord";
			btnAddWord.Size = new Size(115, 23);
			btnAddWord.TabIndex = 15;
			btnAddWord.Text = "Add Word";
			btnAddWord.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(136, 372);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(115, 23);
			btnClose.TabIndex = 19;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// frmSpellChecker
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(253, 407);
			Controls.Add(btnClose);
			Controls.Add(btnSearch);
			Controls.Add(btnIgnoreWords);
			Controls.Add(btnAddAutoCorrect);
			Controls.Add(btnAddWord);
			Controls.Add(btnChange);
			Controls.Add(btnChangeAll);
			Controls.Add(btnIgnoreAll);
			Controls.Add(btnIgnore);
			Controls.Add(label3);
			Controls.Add(lbSuggestion);
			Controls.Add(txtReplace);
			Controls.Add(txtIncorrect);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtInput);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Name = "frmSpellChecker";
			FormClosing += frmSpellChecker_FormClosing;
			Load += frmSpellChecker_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox txtInput;
		private Label label1;
		private Label label2;
		private TextBox txtIncorrect;
		private TextBox txtReplace;
		private ListBox lbSuggestion;
		private Label label3;
		private Button btnIgnore;
		private Button btnIgnoreAll;
		private Button btnChangeAll;
		private Button btnChange;
		private Button btnSearch;
		private Button btnIgnoreWords;
		private Button btnAddAutoCorrect;
		private Button btnAddWord;
		private Button btnClose;
	}
}