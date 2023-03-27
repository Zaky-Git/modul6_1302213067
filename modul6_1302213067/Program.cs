using modul6_1302213067;

internal class Program
{
    private static void Main(string[] args)
    {
        sayaTubeUser Jepri = new sayaTubeUser("Jepri");
        sayaTubeVideo Video1 = new sayaTubeVideo("Brando got Kicked");
        Jepri.AddVideo(Video1);
        sayaTubeVideo Video2 = new sayaTubeVideo("BrandI got Kicked");
        sayaTubeVideo Video3 = new sayaTubeVideo("BrandE got Kicked");
        Jepri.AddVideo(Video2);
        Jepri.AddVideo(Video3);

        Jepri.PrintAllVideoPlaycount();

        /*Video1.increasePlayCount(100000);*/


    }
}