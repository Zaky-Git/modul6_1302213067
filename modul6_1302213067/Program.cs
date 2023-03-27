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
        sayaTubeVideo Video4 = new sayaTubeVideo("Brand1E got Kicked");
        sayaTubeVideo Video5 = new sayaTubeVideo("BrandE got Kicked");
        sayaTubeVideo Video6 = new sayaTubeVideo("Brand3E got Kicked");
        sayaTubeVideo Video7 = new sayaTubeVideo("BrandE2 got Kicked");
        sayaTubeVideo Video8 = new sayaTubeVideo("Brand45E got Kicked");
        Jepri.AddVideo(Video2);
        Jepri.AddVideo(Video3);
        Jepri.AddVideo(Video4);
        Jepri.AddVideo(Video5);
        Jepri.AddVideo(Video6);
        Jepri.AddVideo(Video7);
        Jepri.AddVideo(Video8);

        Jepri.PrintAllVideoPlaycount();

        /*Video1.increasePlayCount(100000);*/


    }
}