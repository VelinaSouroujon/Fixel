using Fixel.Data.Models;

namespace Fixel.ViewModels.Extensions
{
    public static class EnumDisplayNameExtensions
    {
        public static string ToDisplayName(this RepairStatus status) => status switch
        {
            RepairStatus.Received => "Received",
            RepairStatus.Diagnosing => "Diagnosing",
            RepairStatus.AwaitingApproval => "Awaiting approval",
            RepairStatus.Approved => "Approved",
            RepairStatus.WaitingForParts => "Waiting for parts",
            RepairStatus.InRepair => "In repair",
            RepairStatus.Testing => "Testing",
            RepairStatus.ReadyForCollection => "Ready for collection",
            RepairStatus.Collected => "Collected",
            RepairStatus.Declined => "Declined",
            RepairStatus.Unrepairable => "Unrepairable",
            RepairStatus.Cancelled => "Cancelled"
        };
    }
}
