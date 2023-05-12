using RestSharp;
using Microsoft.AspNetCore.Mvc;
using HackernewsUI.API.DataTransferObject;

namespace HackernewsUI.API.Controllers
{
    [ApiController]
    [Route("api/news")]
    public class UserController : Controller
    {
        private readonly RestClient _client;
        public UserController()
        {
            _client = new RestClient("https://hackernews.api-docs.io/v0/items/story");
        }

        [HttpGet]
        [Route("Get-All-Newsfeed")]
        public  async Task<IActionResult> GetAllNewsFeed()
        {
            var request = new RestRequest("api/news");
            var response = await _client.ExecuteGetAsync<NewsfeedList>(request);

            if(!response.IsSuccessful)
            {
                return StatusCode((int)response.StatusCode, response);
            }
            return Ok(response.Data);
        }
        [HttpGet("{Get-news-by-Id}")]
        public async Task<IActionResult> GetNewsFeed(int Id)
        {
            var request = new RestRequest("api/news/{Id}");
            var response =await _client.ExecuteGetAsync<Newsfeed>(request);
            if(!response.IsSuccessful)
            {
                return NotFound();
            }
            return Ok(response.Data);
        }
        [HttpGet("{get-comments-by-story-Id}")]
        public async Task<IActionResult> DisplayComment(int storyid)
        {
            var request = new RestRequest("api/news/{storyid}");
            var response = await _client.ExecuteGetAsync<Comment>(request);
            if(!response.IsSuccessful)
            {
                return StatusCode((int)response.StatusCode, response);
            }
            return Ok(response.Data);

        }
        [HttpPost("Add-story")]
        public async Task<IActionResult> AddStory([FromBody] Story story)
        {
            var request = new RestRequest("api/news")
                       .AddJsonBody(story);
            var response = await _client.ExecuteGetAsync<Story>(request);
            if(!response.IsSuccessful)
            {
                return StatusCode((int)response.StatusCode, response);

            }
            return StatusCode(201, response.Data);
        }
    }
}
