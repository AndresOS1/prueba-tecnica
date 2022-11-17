using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaApi
{
    public class Hause
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string NameHause { get; set; } = string.Empty;

        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [StringLength(500)]
        public string ServiceElectricPower { get; set; } = string.Empty;

        [StringLength(100)]
        public string ServiceWaterPower { get; set; } = string.Empty;

        [StringLength(100)]
        public string ServiceSewer { get; set; } = string.Empty;


        public int StatusId { get; set; }

        public Status? Status { get; set; }

        public int ZoneId { get; set; }

        public Zone? Zone { get; set; }

    }
}
