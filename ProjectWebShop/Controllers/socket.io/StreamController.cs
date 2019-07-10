using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectWebShop.Model;
using ProjectWebShop.WebSockets;

namespace ProjectWebShop.Controllers.socket.io
{
    [Route("api/[controller]")]
    public class StreamController : Controller
    {
        private ChatRoomHandler m_chatRoomHandler { get; set; }
        public StreamController(ChatRoomHandler chatRoomHandler)
        {
            m_chatRoomHandler = chatRoomHandler;
        }
        // GET api/values
        [HttpGet("getall")]
        public async Task Get()
        {
            var context = ControllerContext.HttpContext;
            var isSocketRequest = context.WebSockets.IsWebSocketRequest;
            if (isSocketRequest)
            {
                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
                await GetMessages(context, webSocket);
            }
            else
            {
                context.Response.StatusCode = 400;
            }
        }

        private async Task GetMessages(HttpContext context, WebSocket webSocket)
        {
            Users us = new Users();
            us.address = "fsfdsd";
            us.email = "fsafdsdf";

            //foreach (var message in messages)
            //{
            //    var bytes = Encoding.ASCII.GetBytes(message);
            //    var arraySegment = new ArraySegment<byte>(bytes);
            //    await webSocket.SendAsync(arraySegment, WebSocketMessageType.Text, true, CancellationToken.None);
            //    Thread.Sleep(2000); //sleeping so that we can see several messages are sent
            //}
            var bytes = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new{jsonuser =us}) );
            var arraySegment = new ArraySegment<byte>(bytes);
            await webSocket.SendAsync(arraySegment, WebSocketMessageType.Text, true, CancellationToken.None);
            await webSocket.SendAsync(new ArraySegment<byte>(null), WebSocketMessageType.Binary, false, CancellationToken.None);
        }
    }
}