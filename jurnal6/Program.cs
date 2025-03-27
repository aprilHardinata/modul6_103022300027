// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("April Hardinata");
        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"review film {i} oleh {user.getName()}");
            video.increasePlayCount(100);
            user.AddVideo(video);
        }
        user.PrintAllVideoPlaycount();
    }
}
