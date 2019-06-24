using System.ComponentModel.DataAnnotations.Schema;

namespace SharpMapServer.Services.Models
{
    public class LayerRecord:NameRecord
    {
        public string Path { get; set; }
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual ServiceRecord Service { get; set; }
    }
}