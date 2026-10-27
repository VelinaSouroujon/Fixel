using Fixel.Data.Models;

namespace Fixel.Web.Extensions
{
    public static class CssClassMappingExtensions
    {
        public static string ToBadgeClass(this RepairStatus status) => status switch
        {
            RepairStatus.Received => "s-received",
            RepairStatus.Diagnosing => "s-diagnosing",
            RepairStatus.AwaitingApproval => "s-awaiting",
            RepairStatus.Approved => "s-approved",
            RepairStatus.WaitingForParts => "s-waiting",
            RepairStatus.InRepair => "s-repair",
            RepairStatus.Testing => "s-testing",
            RepairStatus.ReadyForCollection => "s-ready",
            RepairStatus.Collected => "s-collected",
            RepairStatus.Declined or RepairStatus.Unrepairable or RepairStatus.Cancelled => "s-closed",
            _ => throw new ArgumentOutOfRangeException(nameof(status))
        };

        public static string ToPriorityDotClass(this RepairPriority priority) => priority switch
        {
            RepairPriority.Low => "bg-secondary-subtle",
            RepairPriority.Normal => "bg-primary",
            RepairPriority.High => "bg-warning",
            RepairPriority.Urgent => "bg-danger",
            _ => throw new ArgumentOutOfRangeException(nameof(priority))
        };
    }
}
