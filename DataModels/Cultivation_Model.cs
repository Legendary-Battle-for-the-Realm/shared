using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Cultivation
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int RequiredQi { get; set; }
    }
}