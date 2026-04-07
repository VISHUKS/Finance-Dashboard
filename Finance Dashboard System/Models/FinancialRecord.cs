using System.ComponentModel.DataAnnotations;

namespace Finance_Dashboard_System.Models
{
    public class FinancialRecord
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string RecordType { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
