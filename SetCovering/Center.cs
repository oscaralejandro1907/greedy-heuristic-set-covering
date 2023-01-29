namespace SetCovering;

public class Center
{
    public string Id { get; set; }
    public int Cost { get; set; }
    public Dictionary<string,int> DictDistanceToRegion { get; set; }
    public List<int> ListCoveredRegions { get; set; }

    public Center(string id, int cost)
    {
        Id = id;
        Cost = cost;
        DictDistanceToRegion = new Dictionary<string, int>();
        ListCoveredRegions = new List<int>();
    }
}