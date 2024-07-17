using core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web.Models;
using Newtonsoft.Json;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        List<int> ignored_words = new List<int>();
        List<int> incorrect_words = new List<int>();


        private readonly ILogger<HomeController> _logger;
        private SpellcheckHelper helper = new SpellcheckHelper();



		public async Task<JsonResult> IndexWordsBAC(string? paragraph)
		{
			try
			{
				//var result = service.GetCategories(param);
				//return Json(result);
				if (string.IsNullOrEmpty(paragraph))
				{
					return Json(null);
				}
				ResponseClass response = new ResponseClass();
				var par = await helper.IndexWords(paragraph);
				var rev = await helper.ConvertToPlainText(par);
				//var incorrect_words = await helper.GetIncorrectWordList(words, ignored_words);

				//response.words = words;
				response.incorrect_words = incorrect_words;
				return Json(par);
			}
			catch
			{
				return Json(null);
			}
		}
		public async Task<JsonResult> IndexWords(string? paragraph)
        {
            try
            {
                if (string.IsNullOrEmpty(paragraph))
                {
                    return Json(null);
                }
                var par = await helper.IndexWords(paragraph);
                return Json(par);
            }
            catch
            {
                return Json(null);
            }
        }
		public async Task<JsonResult> ConvertToPlainText(string? paragraph)
		{
			try
			{
				if (string.IsNullOrEmpty(paragraph))
				{
					return Json(null);
				}
				var rev = await helper.ConvertToPlainText(paragraph);
				return Json(rev);
			}
			catch
			{
				return Json(null);
			}
		}

		public async Task<JsonResult> GetSuggestions(string? word)
		{
			try
			{
				//var result = service.GetCategories(param);
				//return Json(result);
				if (string.IsNullOrEmpty(word))
				{
					return Json(null);
				}
				var words = helper.GetSuggestions(word);
				return Json(words);
			}
			catch
			{
				return Json(null);
			}
		}
		public async Task<JsonResult> AddNewWord(string? word)
		{
			try
			{
				//var result = service.GetCategories(param);
				//return Json(result);
				if (string.IsNullOrEmpty(word))
				{
					return Json(null);
				}
				var words = helper.AddNewWord(word);
				return Json(words);
			}
			catch
			{
				return Json(null);
			}
		}











		public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }

    public class ResponseClass()
    {
        public List<Word> words { get; set; } = new List<Word>();
        public List<int> incorrect_words { get; set; } = new List<int>();
    }
}
