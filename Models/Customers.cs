using System.ComponentModel.DataAnnotations;

namespace Jason_CRUD.Models
{
    public class Customers
    {
        [Key]
        [MaxLength(100)]
        public string Id { get; set; }
        [MaxLength(250)]
        public string FirstName { get; set; }
        [MaxLength(250)]
        public string LastName { get; set; }
        [MaxLength(750)]
        public string Email { get; set; }
    }
}
