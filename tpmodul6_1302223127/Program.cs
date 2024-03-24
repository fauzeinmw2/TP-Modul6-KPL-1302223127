using tpmodul6_1302223127;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Fauzein Mulya Warman");

        video.IncreasePlayCount(100);
        video.PrintVideoDetail();
    }
}