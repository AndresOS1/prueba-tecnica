using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaApi
{
    public class Zone
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string NameZone { get; set; } = string.Empty;
    }
}
