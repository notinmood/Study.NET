namespace CoreConsoleApp.设计模式.Facade外观模式.UsePattern
{
    public class Client
    {
        public static void Index()
        {
            //使用Facade
            new Facade().generate();
        }
    }

}
