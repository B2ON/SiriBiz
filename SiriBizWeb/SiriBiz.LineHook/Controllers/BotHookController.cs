using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SiriBiz.LineHook.Models;

namespace SiriBiz.LineHook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotHookController : ControllerBase
    {
        private readonly ILogger<BotHookController> _logger;
        private readonly LineBotSettings _lineBotSettings;

        public BotHookController(ILogger<BotHookController> logger, IOptions<LineBotSettings> options)
        {
            _logger = logger;
            _lineBotSettings = options?.Value;
        }

        [HttpGet]
        public IActionResult Hi()
        {
            _logger.LogInformation($"Invork Get BotHook");
            return Ok(DateTime.Now);
        }

        [HttpPost]
        [LineAuthorization]
        public async Task<IActionResult> Hook()
        {
            // var messagingClient = new LineMessagingClient(_lineBotSettings.ChannelAccessToken);

            // push single message (text, image, video, audio...)
            //await messagingClient.PushMessage("User ID", "PushMessageTest");


            // push multiple messages (text, image, video, audio...)
            // await messagingClient.PushMessage("User ID", IList < ILineMessage > messages);

            // push single text message
            //await messagingClient.PushMessage("User ID", "text message");

            // push multiple text message
            //await messagingClient.PushMessage("User ID", new[] { "text message 1", "text message 2" });

            // multicast message
            //await messagingClient.MulticastMessage(LineMulticastMessage);

            // multicast single text message
            //await messagingClient.MulticastMessage(new[] { "User ID 1", "User ID 2" }, "text message");
            return Ok(true);
        }
    }
}