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
    }
}
