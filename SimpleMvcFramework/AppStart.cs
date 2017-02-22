namespace SimpleMvcFramework
{
    using SimpleHttpServer;
    using SimpleMvcFramework.MVC;

    class AppStart
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer(8081, RouteTable.Routes);
            MvcEngine.Run(server);
        }
    }
}