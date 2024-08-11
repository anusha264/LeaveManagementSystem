using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypesReadOnlyVM: BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;
        
        [Display(Name = "Number Of Days")]
        public int NumberOfDays { get; set; }
    }
}
