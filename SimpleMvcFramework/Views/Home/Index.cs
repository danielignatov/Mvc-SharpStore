﻿namespace SimpleMvcFramework.Views.Home
{
    using SimpleMvcFramework.MVC.Interfaces;
    using System.IO;

    public class Index : IRenderable
    {
        public string Render()
        {
            return File.ReadAllText("../../content/home.html");
        }
    }
}