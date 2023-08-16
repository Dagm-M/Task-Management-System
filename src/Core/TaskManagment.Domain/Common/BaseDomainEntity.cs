using System.ComponentModel.DataAnnotations;

namespace TaskManagment.Domain.Common
{
    public class BaseDomainEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}