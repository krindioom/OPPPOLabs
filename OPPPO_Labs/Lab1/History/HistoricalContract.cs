namespace Lab1.History;

internal class HistoricalContract : HistoricalEventBase
{
    public HashSet<string> Governments { get; private set; } = new HashSet<string>();

    public HistoricalContract(DateOnly date, string eventName)
        :base(date, eventName)
    {
        
    }

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

    public HistoricalContract AddGovernments(params string[] governments)
    {
        foreach (var government in governments)
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

        return this;
    }

    public override string GetDetails()
    {
        var governmentsList = Governments.Count > 0 ? string.Join(", ", Governments) : "No governments";

        return base.GetDetails() + governmentsList;
    }
}
