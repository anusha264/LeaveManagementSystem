using LeaveManagementSystem.Web.Models.LeaveTypes;
using System.ComponentModel.DataAnnotations;

public class LeaveTypeEditVM: BaseLeaveTypeVM
{
    
    [Required]
    [Length(4, 150, ErrorMessage = "Length is requried between 4 to 150")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(1, 90)]
    [Display(Name = "Number Of Days")]
    public int NumberOfDays { get; set; }
}