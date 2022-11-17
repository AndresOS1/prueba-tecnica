using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaApi
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        
        
        [StringLength(100)]
        public string StatusName { get; set; } = string.Empty;

    }
}
