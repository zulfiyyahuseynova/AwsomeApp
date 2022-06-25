using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AwesomeApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Profession { get; set; }
        public string Image { get; set; }
        public string Comment { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
