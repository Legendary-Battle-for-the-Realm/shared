using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Effect
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Ref { get; set; }
    }
}