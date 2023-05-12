using RestSharp;
using Microsoft.AspNetCore.Mvc;

namespace HackernewsUI.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly RestClient _client;
        public UserController()
        {
            _client = new RestClient("https://hackernews.api-docs.io/v0/items/story");
        }

        [HttpGet]
        public Task<>
    }
}
