namespace SimpleMvcFramework.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Message
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        #endregion
    }
}