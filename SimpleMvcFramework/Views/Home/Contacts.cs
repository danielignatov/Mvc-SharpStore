namespace SimpleMvcFramework.Views.Home
{
    using SimpleMvcFramework.MVC.Interfaces;
    using System.IO;

    public class Contacts : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../content/contacts.html");
        }
    }
}