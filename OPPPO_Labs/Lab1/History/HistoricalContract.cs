namespace Lab1.History;

internal class HistoricalContract : HistoricalEventBase
{
    public HashSet<string> Governments { get; private set; } = new HashSet<string>();

    public void AddGovernment(string government)
    {
        if (string.IsNullOrWhiteSpace(government))
        {
            throw new ArgumentNullException("пустая строка");
        }

        government
            .Trim()
            .ToLower();
        Governments.Add(government);
    }
}
