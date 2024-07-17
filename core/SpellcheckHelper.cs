using System.Drawing;
using System.Text.RegularExpressions;

namespace core
{
    public class SpellcheckHelper
    {
        SpellcheckEngine engine = new SpellcheckEngine();
        public async Task<string> IndexWords(string paragraph)
        {
            int index = 1;
            char[] separators = new char[] { ' ', '\r', '\n' };
            char[] symbols = new char[] { '/', ',', '(', ')', '{', '}', '[', ']', ':', '.', '!', '?', '।' };

            string result = "";
            int lastIndex = 0;

            while (lastIndex < paragraph.Length)
            {
                // Find the next separator or symbol
                int nextSeparatorIndex = paragraph.IndexOfAny(separators, lastIndex);
                int nextSymbolIndex = paragraph.IndexOfAny(symbols, lastIndex);

                int nextWordEnd = Math.Min(
                    nextSeparatorIndex == -1 ? int.MaxValue : nextSeparatorIndex,
                    nextSymbolIndex == -1 ? int.MaxValue : nextSymbolIndex
                );

                if (nextWordEnd == int.MaxValue)
                {
                    nextWordEnd = paragraph.Length;
                }

                if (nextWordEnd > lastIndex)
                {
                    string wordText = paragraph.Substring(lastIndex, nextWordEnd - lastIndex);
                    string word = wordText.Trim(symbols);
                    string style = "";
                    string clas = "";
                    bool exists = await engine.IsWordExists(word);
                    if (!exists)
                    {
                        style = "background-color:red;";
                        clas = "incorrect";
                    }
                    else clas = "correct";
                    result += $"<span id='{index}' class='{clas}'>{word}</span>";
                    index++;
                }

                if (nextWordEnd < paragraph.Length)
                {
                    result += paragraph[nextWordEnd];
                    lastIndex = nextWordEnd + 1;
                }
                else
                {
                    lastIndex = nextWordEnd;
                }
            }

            return result;
        }
        public async Task<string> ConvertToPlainText(string indexedParagraph)
        {
            string pattern = @"<span[^>]*>(.*?)<\/span>";
            string plainText = Regex.Replace(indexedParagraph, pattern, "$1");

            return plainText;
        }
        public List<Word> IndexWordsBac(string paragraph)
        {
            List<Word> words = new List<Word>();
            words.Clear();
            // Split the text into words and store them as Word objects
            int startIndex = 0;
            int index = 1;
            char[] separators = new char[] { ' ', '\r', '\n' };
            char[] symbols = new char[] { '/', ',', '(', ')', '{', '}', '[', ']', ':' };
            foreach (string wordText in paragraph.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                string word = wordText.Trim(symbols);
                words.Add(new Word { id = index, start = startIndex, length = wordText.Length, word = word });
                startIndex += wordText.Length + 1;

                index++;
            }
            return words;
        }
        public async Task<List<string>> GetSuggestions(string word)
        {
            return await engine.GetSuggestions(word);
        }
        public async Task<bool> AddNewWord(string word)
        {
			return await engine.AddNewWord(word);

		}

        public async Task<List<int>> GetIncorrectWordList(List<Word> words, List<int> ignored_words)
        {
            List<int> incorrect_words = new List<int>();

            foreach (var word in words)
            {
                bool ignored = ignored_words.Contains(word.id);
                if (!ignored)
                {
                    bool exists = await engine.IsWordExists(word.word);
                    if (!exists)
                    {
                        incorrect_words.Add(word.id);
                    }
                }
            }
            return incorrect_words;
        }
    }
}
