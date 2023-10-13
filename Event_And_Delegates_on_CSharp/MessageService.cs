using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_And_Delegates_on_CSharp
{
    public class MessageService
    {
        public void OnVideoEncodedMessageService(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending a message....!" + args.video.Title);
        }
    }
}
