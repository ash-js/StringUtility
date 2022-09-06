namespace StringUtility;

public interface IWorkflow
{
    void Add(IActivity activity);
    void Remove(IActivity activity);
    IEnumerable<IActivity> GetActivities();
}
public class Workflow : IWorkflow
{
    private readonly List<IActivity> _activities;

    public Workflow()
    {
        _activities = new List<IActivity>();
    }

    public void Add(IActivity activity)
    {
        _activities.Add(activity);
    }

    public void Remove(IActivity activity)
    {
        _activities.Remove(activity);
    }

    public IEnumerable<IActivity> GetActivities()
    {
        return _activities;
    }
}
