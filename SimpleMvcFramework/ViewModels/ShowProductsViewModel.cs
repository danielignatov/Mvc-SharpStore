namespace SimpleMvcFramework.ViewModels
{
    using Models;
    using System.Collections.Generic;

    public class ShowProductsViewModel
    {
        #region Constructors
        public ShowProductsViewModel()
        {
            this.Knifes = new List<Knife>();
        }
        #endregion

        #region Properties
        public string Product { get; set; }

        public List<Knife> Knifes { get; set; }
        #endregion
    }
}