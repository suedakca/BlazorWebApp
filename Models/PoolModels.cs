using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Models
{
    public class PoolDefinition
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = ""; // "Commercial" or "Projects"
        public string DisplayName { get; set; } = "";
        public string Description { get; set; } = "";
        
        // Dynamic Data Configuration
        public string TableName { get; set; } = ""; // Actual DB table name
        public string? ConnectionString { get; set; } // Optional: External DB connection string
        
        public ICollection<PoolColumn> Columns { get; set; } = new List<PoolColumn>();
    }

    public class PoolColumn
    {
        public int Id { get; set; }
        public int PoolDefinitionId { get; set; }
        [ForeignKey("PoolDefinitionId")]
        public PoolDefinition? PoolDefinition { get; set; }

        public string HeaderText { get; set; } = "";
        public string PropertyName { get; set; } = ""; // Maps to property in Record class
        public string DataType { get; set; } = "Text"; // Text, Date, Number, Currency, Badge, ProgressBar, Avatar
        public string Width { get; set; } = ""; // CSS value
        public string CssClass { get; set; } = ""; // Additional classes for TD
        public string HeaderCssClass { get; set; } = "";
        public int OrderIndex { get; set; }
        public bool IsVisible { get; set; } = true;
    }

    // Record for DataPool2 (Ticari Kayıtlar)
    public class CommercialRecord
    {
        public int Id { get; set; }
        public string RefNo { get; set; } = "";
        public DateTime Date { get; set; }
        public string CustomerName { get; set; } = "";
        public string Region { get; set; } = "";
        public string Category { get; set; } = "";
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public string Status { get; set; } = "";
    }

    // Record for DataPool3 (Proje Yönetimi)
    public class ProjectRecord
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Status { get; set; } = "";
        public int Progress { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Budget { get; set; }
        public DateTime DueDate { get; set; }
    }
}
