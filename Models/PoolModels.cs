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

    // Record for Branch Inspection (Veri Havuzu 2)
    public class BranchInspectionRecord
    {
        public int Id { get; set; }
        public string BranchCode { get; set; } = "";
        public string BranchName { get; set; } = "";
        public string TaskId { get; set; } = "";
        public string BranchType { get; set; } = "";
        public DateTime OpeningDate { get; set; }
        public string City { get; set; } = "";
        public DateTime ReportDate { get; set; }
        public bool HasInspectionReport { get; set; } // Button
        public DateTime AuditPeriodStart { get; set; }
        public DateTime AuditPeriodEnd { get; set; }
        public string IndividualIdDeficiencies { get; set; } = ""; // Button (Label)
        public string PhotoDeficiencies { get; set; } = ""; // Button (Label)
        public string PhotoUpToDate { get; set; } = ""; // Button (Label)
        public string SignatureDeficiencies { get; set; } = ""; // Button (Label)
        public string SignatureUpToDate { get; set; } = ""; // Button (Label)
        public string SystemDeficiencies { get; set; } = ""; // Button (Label)
        public string SystemUpToDate { get; set; } = ""; // Button (Label)
        public string ReceiptDeficiencies { get; set; } = ""; // Button (Label)
        public string ReceiptUpToDate { get; set; } = ""; // Button (Label)
        public string ReconciliationDeficiencies { get; set; } = "";
        public string ReconciliationUpToDate { get; set; } = "";
        public double TotalScore { get; set; }
        public double RiskScore { get; set; }
        public string OverallOpinion { get; set; } = "";
        public int CustomerCount { get; set; }
        public int MissingIdCount { get; set; }
        public int MissingIdExcludingDivit { get; set; }
        public int CashTransactionCount { get; set; }
        public int MissingReceiptCount { get; set; }
        public int ValidReceiptCount { get; set; }
        public bool IsBranchInterviewed { get; set; }
        public DateTime? BranchInterviewDate { get; set; }
    }
}
