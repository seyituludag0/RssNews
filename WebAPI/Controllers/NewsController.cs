using Business.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet("MynetGetAllNews")]
        public List<string> MynetGetAllNews()
        {
            return _newsService.MynetGetAllNewsTitle();
        }

        [HttpGet("MynetNewsTitleSearch")]
        public string MynetNewsTitleSearch(string key)
        {
            return _newsService.MynetNewsTitleSearch(key);
        }

        [HttpGet("NewYorkGetNews")]
        public List<string> NewYorkGetNews()
        {
            return _newsService.NewYorkGetNews();
        }




        [HttpGet("GetAllFeedburnerNews")]
        public List<string> GetAllFeedburnerNews()
        {
            return _newsService.GetAllFeedburnerNews();
        }

        [HttpGet("GetAllRetaildetailbe")]
        public List<string> GetAllRetaildetailbe()
        {
            return _newsService.GetAllRetaildetailbe();
        }

        [HttpGet("GetAllAcrossNews")]
        public List<string> GetAllAcrossNews()
        {
            return _newsService.GetAllAcrossNews();
        }

        [HttpGet("GetAllNews")]
        public List<string> GetAllNews()
        {
            var getAllNews = GetAllFeedburnerNews(); GetAllRetaildetailbe(); GetAllAcrossNews();
            return getAllNews;
        }

    }
}
