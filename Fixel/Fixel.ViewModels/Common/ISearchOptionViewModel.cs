namespace Fixel.ViewModels.Common
{
    public interface ISearchOptionViewModel
    {
        int Id { get; }

        string PrimaryText { get; }

        string? SecondaryText { get; }

        string DisplayText { get; }
    }
}
