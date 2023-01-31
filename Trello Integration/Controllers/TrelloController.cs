using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Trello_Integration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrelloController : ControllerBase
    {
        private readonly string boardId;
        private readonly string apiKey;
        private readonly string apiToken;


        public TrelloController()
        {
            boardId = "lGjOw5Hj";
            apiKey = "9170f691ec81338b951f93da9d63c4b8";
            apiToken = "ATTA20cc4ff560507973b452770b4f98fcc5774f3dcbc15a5abe2d390f2953275feb1DAFF002";
        }


        [HttpGet]
        public async Task<ActionResult> GetBoard()
        {
            var client = new RestClient($"https://api.trello.com/1/boards/{boardId}?key={apiKey}&token={apiToken}");
            var request = new RestRequest();
            var response = await client.GetAsync(request);

            return Ok(response.Content);
        }

        [HttpPost]
        public ActionResult CreateList()
        {
            return NotFound();
        }
    }
}
