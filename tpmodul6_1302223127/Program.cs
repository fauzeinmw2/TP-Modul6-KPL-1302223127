using tpmodul6_1302223127;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Fauzein Mulya Warman");

        video.PrintVideoDetail();

        for (int i = 1; i <= 217; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetail();

        //SayaTubeVideo video2 = new SayaTubeVideo(null);

    }
}