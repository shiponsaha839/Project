
namespace core
{
	public class SpellcheckEngine
    {
        public string path = AppDomain.CurrentDomain.BaseDirectory + "/Dictionaries/bn_BD.";
		public NHunspell.Hunspell hunspell;
		public List<Word> words = new List<Word>();
		public List<int> ignored_words = new List<int>();
		public int? selected_word = null;
		public SpellcheckEngine()
		{
			hunspell = new NHunspell.Hunspell(path + "aff", path + "dic");
		}

		public async Task<bool> IsWordExists(string word)
		{
			return hunspell.Spell(word);
		}
		public async Task<List<string>> GetSuggestions(string word)
		{
			return hunspell.Suggest(word);
		}
		public async Task<bool> AddNewWord(string word)
		{
			return true;
		}

	}
}
