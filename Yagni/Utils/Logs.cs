namespace YagniExample;

public class Logs
{
    private List<int> logs;

    public Logs()
    {
        logs = new List<int>();
    }

    public void addLog(int attempt)
    {
        logs.Add(attempt);
    }
}
