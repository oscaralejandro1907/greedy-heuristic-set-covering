namespace SetCovering;

public class Region
{
    public string Id { get; set; }
    public Dictionary<string,int> DictDistanceToRegion { get; set; }    //Distances between the centers of each pair of zones
    public List<string> ListReachableFrom { get; set; } //To cover this region I can build a Center in either of these
    
    public Region(string id)
    {
        Id = id;
        DictDistanceToRegion = new Dictionary<string, int>();
        ListReachableFrom = new List<string>();
    }
}