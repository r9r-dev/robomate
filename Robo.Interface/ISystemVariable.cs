namespace Robo.Interface
{
    public interface ISystemVariable
    {
        string Category { get; }
        string UniqueName { get; }
        string Description { get; }
        string GetValue(params string[] args);
        string Default { get; }

    }
}
