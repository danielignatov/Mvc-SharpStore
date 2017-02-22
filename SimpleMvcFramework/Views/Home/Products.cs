namespace SimpleMvcFramework.Views.Home
{
    using MVC.Interfaces.Generic;
    using SimpleMvcFramework.MVC.Interfaces;
    using System.IO;
    using System.Text;
    using ViewModels;
    using System;

    public class Products : IRenderable<ShowProductsViewModel>
    {
        public ShowProductsViewModel Model { get; set; }

        public string Render()
        {
            string page = File.ReadAllText("../../content/products.html");

            StringBuilder contentBuilder = new StringBuilder();

            foreach (var knife in Model.Knifes)
            {
                contentBuilder.AppendLine("<div class=\"col-lg-4 col-md-4 col-sm-12\"><div class=\"panel panel-default\"><div class=\"panel-body\">" +
                                          $"<img class=\"img -responsive\" src=\"{knife.ImageUrl}\"></div>" +
                                          "<div class=\"container\">" +
                                          $"<h1>{knife.Name}</h1>" +
                                          $"<p>${knife.Price}</p>" +
                                          "<button type=\"submit\" class=\"btn btn-primary\">Buy Now</button></div><br></div></div>");
            }

            page = string.Format(page, contentBuilder.ToString());

            return page;
        }
    }
}