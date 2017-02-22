namespace SimpleMvcFramework.Views.Home
{
    using SimpleMvcFramework.MVC.Interfaces;
    using System.IO;

    public class Products : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../content/products.html");
        }
    }
}