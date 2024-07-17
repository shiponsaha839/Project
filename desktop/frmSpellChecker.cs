using core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop
{
	public partial class frmSpellChecker : Form
	{
		SpellcheckEngine engine = new SpellcheckEngine();
		List<Word> words = new List<Word>();
		List<int> ignored_words = new List<int>();
		int? selected_word = null;
		public string CorrectedText { get; private set; }
		public frmSpellChecker(string text)
		{
			InitializeComponent();
			txtInput.Text = text;
		}

		private void frmSpellChecker_Load(object sender, EventArgs e)
		{
			// Index words
			IndexWords();
			// Start checking spellings
			CheckSpellings();
			txtInput.Select(0, 0);
		}

		private void IndexWords()
		{
			words.Clear();
			// Split the text into words and store them as Word objects
			int startIndex = 0;
			int index = 1;
			char[] separators = new char[] { ' ', '\r', '\n' };
			char[] symbols = new char[] { '/', ',', '(', ')', '{', '}', '[', ']', ':' };
			foreach (string wordText in txtInput.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries))
			{
				string word = wordText.Trim(symbols);
				words.Add(new Word { id = index, start = startIndex, length = wordText.Length, word = word });
				startIndex += wordText.Length + 1;

				index++;
			}
		}

		private async Task CheckSpellings()
		{
			txtInput.SelectAll(); // Clear previous selections
			txtInput.SelectionBackColor = Color.White;
			txtInput.SelectionColor = Color.Black;

			foreach (var word in words)
			{
				bool ignored = ignored_words.Contains(word.id);
				if (!ignored)
				{
					//bool exists = hunspell.Spell(word.word);
					bool exists = await engine.IsWordExists(word.word);
					if (!exists)
					{
						selected_word = word.id;
						txtIncorrect.Text = word.word;
						lbSuggestion.Items.Clear();
						//var list = hunspell.Suggest(word.word);
						var list = await engine.GetSuggestions(word.word);
						foreach (string suggestion in list)
						{
							lbSuggestion.Items.Add(suggestion);
							//Console.WriteLine($"- {suggestion}");
						}
						HighlightWord(word);
						break;
					}
				}
			}
		}

		private void HighlightWord(Word word)
		{
			txtInput.Select(word.start, word.length);
			txtInput.SelectionBackColor = Color.Yellow;
			txtInput.SelectionColor = Color.Red;
			txtInput.ScrollToCaret();
		}




		private void btnIgnore_Click(object sender, EventArgs e)
		{
			if (selected_word is not null)
			{
				ignored_words.Add(selected_word.Value);
			}
			CheckSpellings();
		}

		private void btnIgnoreAll_Click(object sender, EventArgs e)
		{
			if (selected_word is not null)
			{
				var word = words.Find(w => w.id == selected_word);
				var same_words = words.FindAll(w => w.word == words.Find(w => w.word == word.word).word).ToList();
				foreach (var w in same_words)
				{
					ignored_words.Add(w.id);
				}
			}
			CheckSpellings();
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (selected_word is not null)
			{
				Word word = words.Find(w => w.id == selected_word);
				txtInput.Select(word.start, word.length);
				txtInput.SelectedText = txtReplace.Text;
				IndexWords();
				CheckSpellings();
				txtReplace.Text = "";
			}
		}

		private void btnChangeAll_Click(object sender, EventArgs e)
		{
			//Apply the change to all occurrences of the word
			if (selected_word is not null)
			{
				Word word = words.Find(w => w.id == selected_word);
				var same_words = words.FindAll(w => w.word == words.Find(w => w.word == word.word).word).ToList();
				foreach (var w in same_words)
				{
					txtInput.Select(w.start, w.length);
					txtInput.SelectedText = txtReplace.Text;
				}
				IndexWords();
				CheckSpellings();
				txtReplace.Text = "";
			}
		}

		private void btnAddWord_Click(object sender, EventArgs e)
		{
			//hunspell.Add(txtIncorrect.Text);
			throw new NotImplementedException();
		}

		private void btnAddAutoCorrect_Click(object sender, EventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void btnIgnoreWords_Click(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ApplyChanges()
		{
			CorrectedText = txtInput.Text;
			DialogResult = DialogResult.OK;
		}

		private void lbSuggestion_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtReplace.Text = lbSuggestion.SelectedItem.ToString();
		}

		private void txtReplace_TextChanged(object sender, EventArgs e)
		{
			if (txtReplace.Text.Length > 0)
			{
				btnChange.Enabled = true;
				btnChangeAll.Enabled = true;
			}
			else
			{
				btnChange.Enabled = false;
				btnChangeAll.Enabled = false;
			}
		}

		private void frmSpellChecker_FormClosing(object sender, FormClosingEventArgs e)
		{
			ApplyChanges();
		}
	}

}
