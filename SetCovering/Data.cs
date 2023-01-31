namespace SetCovering;

public class Data
{
    public List<Center> ListCenters { get; set; }
    public List<Region> ListRegions { get; set; }
    public int Tresponse {get; set; }

    public Data()
    {
        Tresponse = 8;

        ListRegions = new List<Region>();
        Region r1 = new Region("r1");
        Region r2 = new Region("r2");
        Region r3 = new Region("r3");
        Region r4 = new Region("r4");
        Region r5 = new Region("r5");
        Region r6 = new Region("r6");
        Region r7 = new Region("r7");
        
        ListRegions.Add(r1);
        ListRegions.Add(r2);
        ListRegions.Add(r3);
        ListRegions.Add(r4);
        ListRegions.Add(r5);
        ListRegions.Add(r6);
        ListRegions.Add(r7);
        
        Center c1 = new Center("c1","r1",100);
        Center c2 = new Center("c2","r2",80);
        Center c3 = new Center("c3","r3",120);
        Center c4 = new Center("c4","r4",110);
        Center c5 = new Center("c5","r5",90);
        Center c6 = new Center("c6","r6",90);
        Center c7 = new Center("c7","r7",110);
        
        r1.DictDistanceToRegion.Add("r1",0);
        r1.DictDistanceToRegion.Add("r2",4);
        r1.DictDistanceToRegion.Add("r3",12);
        r1.DictDistanceToRegion.Add("r4",6);
        r1.DictDistanceToRegion.Add("r5",15);
        r1.DictDistanceToRegion.Add("r6",10);
        r1.DictDistanceToRegion.Add("r7",8);
        
        r2.DictDistanceToRegion.Add("r1",8);
        r2.DictDistanceToRegion.Add("r2",0);
        r2.DictDistanceToRegion.Add("r3",15);
        r2.DictDistanceToRegion.Add("r4",60);
        r2.DictDistanceToRegion.Add("r5",7);
        r2.DictDistanceToRegion.Add("r6",2);
        r2.DictDistanceToRegion.Add("r7",3);
        
        r3.DictDistanceToRegion.Add("r1",50);
        r3.DictDistanceToRegion.Add("r2",13);
        r3.DictDistanceToRegion.Add("r3",0);
        r3.DictDistanceToRegion.Add("r4",8);
        r3.DictDistanceToRegion.Add("r5",6);
        r3.DictDistanceToRegion.Add("r6",5);
        r3.DictDistanceToRegion.Add("r7",9);
        
        r4.DictDistanceToRegion.Add("r1",9);
        r4.DictDistanceToRegion.Add("r2",11);
        r4.DictDistanceToRegion.Add("r3",8);
        r4.DictDistanceToRegion.Add("r4",0);
        r4.DictDistanceToRegion.Add("r5",9);
        r4.DictDistanceToRegion.Add("r6",10);
        r4.DictDistanceToRegion.Add("r7",3);
        
        r5.DictDistanceToRegion.Add("r1",50);
        r5.DictDistanceToRegion.Add("r2",8);
        r5.DictDistanceToRegion.Add("r3",4);
        r5.DictDistanceToRegion.Add("r4",10);
        r5.DictDistanceToRegion.Add("r5",0);
        r5.DictDistanceToRegion.Add("r6",2);
        r5.DictDistanceToRegion.Add("r7",27);
        
        r6.DictDistanceToRegion.Add("r1",30);
        r6.DictDistanceToRegion.Add("r2",5);
        r6.DictDistanceToRegion.Add("r3",7);
        r6.DictDistanceToRegion.Add("r4",9);
        r6.DictDistanceToRegion.Add("r5",3);
        r6.DictDistanceToRegion.Add("r6",0);
        r6.DictDistanceToRegion.Add("r7",27);
        
        r7.DictDistanceToRegion.Add("r1",8);
        r7.DictDistanceToRegion.Add("r2",5);
        r7.DictDistanceToRegion.Add("r3",9);
        r7.DictDistanceToRegion.Add("r4",7);
        r7.DictDistanceToRegion.Add("r5",25);
        r7.DictDistanceToRegion.Add("r6",27);
        r7.DictDistanceToRegion.Add("r7",0);
        
        ListCenters = new List<Center>();
        
        ListCenters.Add(c1);
        ListCenters.Add(c2);
        ListCenters.Add(c3);
        ListCenters.Add(c4);
        ListCenters.Add(c5);
        ListCenters.Add(c6);
        ListCenters.Add(c7);
        
        DetermineCoverParameter();
        DetermineCentersCovering();
    }

    public void DetermineCoverParameter()
    { //To cover a region, from where can I reach it
        foreach (var r in ListRegions)
        {
            foreach (var d in r.DictDistanceToRegion)
            {
                if (d.Value <= Tresponse)
                { //In order to cover r, I can build in this region
                    r.ListReachableFrom.Add(d.Key);
                }
            }
        }
    }

    public void DetermineCentersCovering()
    {
        foreach (var center in ListCenters)
        {
            Region? centerRegion = ListRegions.Find(r => r.Id.Equals(center.BelongingRegion));
            if (centerRegion!=null)
            {
                foreach (var region in ListRegions)
                {
                    if (region.ListReachableFrom.Contains(centerRegion.Id))
                    {
                        center.ListCoveredRegions.Add(region);
                    }

                }
            }
        }
    }
    
}