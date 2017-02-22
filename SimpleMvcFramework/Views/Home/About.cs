namespace SimpleMvcFramework.Views.Home
{
    using SimpleMvcFramework.MVC.Interfaces;
    using System.IO;

    public class About : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../content/about.html");
        }
    }
}