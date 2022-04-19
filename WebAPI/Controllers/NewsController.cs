using Business.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
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

        [HttpGet("NewYorkGetNews")]
        public List<string> NewYorkGetNews()
        {
            return _newsService.NewYorkGetNews();
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
            return _newsService.GetAllNews();
        }

    }
}
