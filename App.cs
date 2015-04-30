using Stormancer;
using Stormancer.Core;
using System.Collections.Generic;

namespace Test
{
    public class Startup
    {
        //The runtime calls this method on startup to initialize the server.
        public void Run(IAppBuilder builder)
        {
            //Declares a scene template called "hello"
            builder.SceneTemplate("hello", scene =>
            {
                //Adds an handler executed whenever a peer connects to the scene.
                scene.OnConnected.Add(async peer=>{
                  //Sends the string "hello world!" to the peer that just connected.
                  peer.Send("msg",s=> peer.Serializer().Serialize("hello world!",s), PacketPriority.MEDIUM_PRIORITY, PacketReliability.RELIABLE);
                });
            });
        }
    }
}
