namespace SetCovering;

public class Center
{
    public string Id { get; set; }
    public int Cost { get; set; }
    public string BelongingRegion { get; set; }
    public List<Region> ListCoveredRegions { get; set; } //If installed, this center can cover these regions
    public double Ratio { get; set; }

    public Center(string id, string region,int cost)
    {
        Id = id;
        BelongingRegion = region;
        Cost = cost;
        ListCoveredRegions = new List<Region>();
    }
}