using System.ComponentModel.DataAnnotations.Schema;

namespace API.API.DAL.Models
{
    public class Owner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
