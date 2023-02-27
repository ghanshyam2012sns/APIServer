using System; 
using System.ComponentModel.DataAnnotations;

namespace APIServer.Models
{
    public class Country
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class StateMaster
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
    }
}
