using Event_And_Delegates_on_CSharp;

public class Program
{
    static void Main(string[] args)
    {
        Video video = new Video()
        {
            Title = "Video 1"
        };
        VideoEncoder videoEncoder = new VideoEncoder();
        MailService mailService = new MailService();
        MessageService messageService = new MessageService();

        videoEncoder.videoEncoded += mailService.OnVideoEncoded;
        videoEncoder.videoEncoded += messageService.OnVideoEncodedMessageService;

        videoEncoder.Encode(video);

    }
}
