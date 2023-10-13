using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Event_And_Delegates_on_CSharp
{
    public class VideoEncoder
    {
        // To make this class a event producer we have to do following 3 things
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // Here we are using delegate to handle events

        // After .net 2 or 3 they provide a built in class for event handler. So we don't need
        // to use delegates to manage event. Instead we can use the following line
        //public event EventHandler<VideoEventArgs> videoEncoded;

        public event VideoEncodedEventHandler videoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video with name " + video.Title);
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(videoEncoded != null)
            {
                videoEncoded(this, new VideoEventArgs() { video = video});
            }
        }
    }
}
