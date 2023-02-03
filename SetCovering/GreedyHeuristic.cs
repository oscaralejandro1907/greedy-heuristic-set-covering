namespace SetCovering;

public class GreedyHeuristic
{
    public Data Instance { get; set; }
    public List<Center> ListCentersToBuild { get; set; }    //Solution

    public GreedyHeuristic(Data data)
    {
        Instance = data;
        ListCentersToBuild = new List<Center>();
    }

    public void Solve()
    {
        List<Center> listOfPotentialCenters = new List<Center>(Instance.ListCenters);
        List<Region> listUncoveredRegions = new List<Region>(Instance.ListRegions);
        while (listUncoveredRegions.Count>0)
        {
            CalculateCentersRatio(listOfPotentialCenters);
            listOfPotentialCenters = listOfPotentialCenters.OrderBy(c => c.Ratio).ToList();
            //Pick the center with the least ratio value
            Center selectedCenter = listOfPotentialCenters.First();
            //Add the center to Solution
            ListCentersToBuild.Add(selectedCenter);
            //Update values
            listOfPotentialCenters.Remove(selectedCenter);
            listUncoveredRegions = UpdateUncoveredRegions(listUncoveredRegions,selectedCenter);
            UpdateCenterCovering(listOfPotentialCenters, listUncoveredRegions);
        }
    }
    
    public void CalculateCentersRatio(List<Center> listCenters){
        foreach (var center in listCenters)
        {
            center.Ratio = (double)center.Cost / center.ListCoveredRegions.Count;
        }
    }

    public List<Region> UpdateUncoveredRegions(List<Region> listUncoveredRegions, Center center)
    {
        foreach (var region in center.ListCoveredRegions)
        {
            if (listUncoveredRegions.Contains(region))
            {
                listUncoveredRegions.Remove(region);
            }
        }

        return listUncoveredRegions;
    }

    public void UpdateCenterCovering(List<Center> listOfCenters, List<Region> listUncoveredRegions)
    {
        foreach (var center in listOfCenters)
        {
            center.ListCoveredRegions.Clear();
            foreach (var region in listUncoveredRegions)
            {
                if (region.ListReachableFrom.Contains(center.BelongingRegion))
                { 
                    center.ListCoveredRegions.Add(region);
                }
            }
        }
    }

    public void Print()
    {
        Console.WriteLine("Centers to build to cover all regions are:");
        foreach (var center in ListCentersToBuild)
        {
            Console.Write(center.Id+" ");
            
        }
    }
}