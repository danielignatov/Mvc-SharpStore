namespace SimpleMvcFramework.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Knife
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        #endregion
    }
}