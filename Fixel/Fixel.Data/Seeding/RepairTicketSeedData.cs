using Fixel.Data.Models;

using static Fixel.Data.Seeding.DeviceSeedData;

namespace Fixel.Data.Seeding
{
    public class RepairTicketSeedData
    {
        public static IReadOnlyList<RepairTicket> RepairTickets { get; } = new List<RepairTicket>
        {
            new RepairTicket
            {
                Id = 1,
                ReferenceNumber = "FF-2026-0001",
                IntakeDate = new DateTime(2026, 7, 8, 10, 15, 0),
                ConditionDescription = "Light scuffs on the frame, screen intact.",
                ReportedProblem = "Battery drops below 80% health and the phone dies at 20%.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = new DateOnly(2026, 7, 15),
                Status = RepairStatus.Collected,
                DeviceId = DeviceIdFor(1)
            },
            new RepairTicket
            {
                Id = 2,
                ReferenceNumber = "FF-2026-0002",
                IntakeDate = new DateTime(2026, 8, 11, 14, 40, 0),
                ConditionDescription = "Small dent on the top-left corner.",
                ReportedProblem = "Rear glass cracked after a fall from a table.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = new DateOnly(2026, 8, 18),
                Status = RepairStatus.Collected,
                DeviceId = DeviceIdFor(2)
            },
            new RepairTicket
            {
                Id = 3,
                ReferenceNumber = "FF-2026-0003",
                IntakeDate = new DateTime(2026, 9, 20, 9, 30, 0),
                ConditionDescription = "Pressure marks near one corner, no case.",
                ReportedProblem = "A dark patch is spreading from one corner of the screen.",
                Priority = RepairPriority.Low,
                ExpectedCompletionDate = null,
                Status = RepairStatus.Declined,
                DeviceId = DeviceIdFor(3)
            },
            new RepairTicket
            {
                Id = 4,
                ReferenceNumber = "FF-2026-0004",
                IntakeDate = new DateTime(2026, 9, 28, 16, 5, 0),
                ConditionDescription = "Burn smell near the charging port, otherwise clean.",
                ReportedProblem = "Laptop does not power on after a power surge.",
                Priority = RepairPriority.Urgent,
                ExpectedCompletionDate = null,
                Status = RepairStatus.Unrepairable,
                DeviceId = DeviceIdFor(4)
            },
            new RepairTicket
            {
                Id = 5,
                ReferenceNumber = "FF-2026-0005",
                IntakeDate = new DateTime(2026, 9, 30, 11, 20, 0),
                ConditionDescription = "Dent on the bottom case corner, charger included.",
                ReportedProblem = "Slow start-up and frequent freezing during video calls.",
                Priority = RepairPriority.Low,
                ExpectedCompletionDate = null,
                Status = RepairStatus.Cancelled,
                DeviceId = DeviceIdFor(5)
            },
            new RepairTicket
            {
                Id = 6,
                ReferenceNumber = "FF-2026-0006",
                IntakeDate = new DateTime(2026, 10, 1, 10, 0, 0),
                ConditionDescription = "Good condition, dust buildup around the vents.",
                ReportedProblem = "Fan runs loudly and the computer shuts down under load.",
                Priority = RepairPriority.High,
                ExpectedCompletionDate = new DateOnly(2026, 10, 18),
                Status = RepairStatus.InRepair,
                DeviceId = DeviceIdFor(6)
            },
            new RepairTicket
            {
                Id = 7,
                ReferenceNumber = "FF-2026-0007",
                IntakeDate = new DateTime(2026, 10, 2, 15, 10, 0),
                ConditionDescription = "Scuffed bezel, strap worn at the clasp.",
                ReportedProblem = "Watch will not charge and the screen stays black.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = new DateOnly(2026, 10, 15),
                Status = RepairStatus.ReadyForCollection,
                DeviceId = DeviceIdFor(7)
            },
            new RepairTicket
            {
                Id = 8,
                ReferenceNumber = "FF-2026-0008",
                IntakeDate = new DateTime(2026, 10, 7, 12, 25, 0),
                ConditionDescription = "Scratched back glass, otherwise good.",
                ReportedProblem = "Rear camera is blurry and rattles when the phone is shaken.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = new DateOnly(2026, 10, 26),
                Status = RepairStatus.Testing,
                DeviceId = DeviceIdFor(8)
            },
            new RepairTicket
            {
                Id = 9,
                ReferenceNumber = "FF-2026-0009",
                IntakeDate = new DateTime(2026, 10, 9, 9, 45, 0),
                ConditionDescription = "Clean screen, small scratch on the back near the camera.",
                ReportedProblem = "Charging port is loose and the phone only charges at certain angles.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = new DateOnly(2026, 11, 6),
                Status = RepairStatus.WaitingForParts,
                DeviceId = DeviceIdFor(9)
            },
            new RepairTicket
            {
                Id = 10,
                ReferenceNumber = "FF-2026-0010",
                IntakeDate = new DateTime(2026, 10, 14, 13, 30, 0),
                ConditionDescription = "Pressure marks near one corner, case missing.",
                ReportedProblem = "Display flickers and shows horizontal lines after waking from sleep.",
                Priority = RepairPriority.High,
                ExpectedCompletionDate = new DateOnly(2026, 10, 31),
                Status = RepairStatus.Approved,
                DeviceId = DeviceIdFor(10)
            },
            new RepairTicket
            {
                Id = 11,
                ReferenceNumber = "FF-2026-0011",
                IntakeDate = new DateTime(2026, 10, 16, 10, 50, 0),
                ConditionDescription = "Minor scratches on the lid, no visible liquid damage.",
                ReportedProblem = "Keyboard keys stick and some letters do not register.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = new DateOnly(2026, 10, 30),
                Status = RepairStatus.AwaitingApproval,
                DeviceId = DeviceIdFor(11)
            },
            new RepairTicket
            {
                Id = 12,
                ReferenceNumber = "FF-2026-0012",
                IntakeDate = new DateTime(2026, 10, 21, 17, 0, 0),
                ConditionDescription = "Heavy wear, missing rubber feet.",
                ReportedProblem = "Battery drains within an hour and the laptop shuts down without warning.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = null,
                Status = RepairStatus.Diagnosing,
                DeviceId = DeviceIdFor(12)
            },
            new RepairTicket
            {
                Id = 13,
                ReferenceNumber = "FF-2026-0013",
                IntakeDate = new DateTime(2026, 10, 23, 9, 15, 0),
                ConditionDescription = "Cracked glass across the lower third, light scuffs on the frame.",
                ReportedProblem = "Screen cracked after a drop and touch is unresponsive in the lower half.",
                Priority = RepairPriority.Normal,
                ExpectedCompletionDate = null,
                Status = RepairStatus.Received,
                DeviceId = DeviceIdFor(13)
            },
            new RepairTicket
            {
                Id = 14,
                ReferenceNumber = "FF-2026-0014",
                IntakeDate = new DateTime(2026, 10, 24, 11, 35, 0),
                ConditionDescription = "Light wear, small dent on the top-left corner.",
                ReportedProblem = "Speaker sounds muffled and callers cannot be heard clearly.",
                Priority = RepairPriority.Low,
                ExpectedCompletionDate = new DateOnly(2026, 11, 2),
                Status = RepairStatus.Received,
                DeviceId = DeviceIdFor(14)
            }
        }.AsReadOnly();

        private static int DeviceIdFor(int ticketId)
        {
            return Devices[(ticketId - 1) % Devices.Count].Id;
        }
    }
}
