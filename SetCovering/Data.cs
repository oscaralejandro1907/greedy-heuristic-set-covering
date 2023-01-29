namespace SetCovering;

public class Data
{
    public List<Center> ListCenters { get; set; }
    public int Tresponse {get; set; }
    public int Nregions { get; set; }

    public Data()
    {
        Nregions = 7;
        Tresponse = 8;

        Center c1 = new Center("c1",100);
        Center c2 = new Center("c2",80);
        Center c3 = new Center("c3",120);
        Center c4 = new Center("c4",110);
        Center c5 = new Center("c5",90);
        Center c6 = new Center("c6",90);
        Center c7 = new Center("c7",110);
        
        c1.DictDistanceToRegion.Add("r2",4);
        c1.DictDistanceToRegion.Add("r3",12);
        c1.DictDistanceToRegion.Add("r4",6);
        c1.DictDistanceToRegion.Add("r5",15);
        c1.DictDistanceToRegion.Add("r6",10);
        c1.DictDistanceToRegion.Add("r7",8);
        
        c2.DictDistanceToRegion.Add("r1",8);
        c2.DictDistanceToRegion.Add("r3",15);
        c2.DictDistanceToRegion.Add("r4",60);
        c2.DictDistanceToRegion.Add("r5",7);
        c2.DictDistanceToRegion.Add("r6",2);
        c2.DictDistanceToRegion.Add("r7",3);
        
        c3.DictDistanceToRegion.Add("r1",50);
        c3.DictDistanceToRegion.Add("r2",13);
        c3.DictDistanceToRegion.Add("r4",8);
        c3.DictDistanceToRegion.Add("r5",6);
        c3.DictDistanceToRegion.Add("r6",5);
        c3.DictDistanceToRegion.Add("r7",9);
        
        c4.DictDistanceToRegion.Add("r1",9);
        c4.DictDistanceToRegion.Add("r2",11);
        c4.DictDistanceToRegion.Add("r3",8);
        c4.DictDistanceToRegion.Add("r5",9);
        c4.DictDistanceToRegion.Add("r6",10);
        c4.DictDistanceToRegion.Add("r7",3);
        
        c5.DictDistanceToRegion.Add("r1",50);
        c5.DictDistanceToRegion.Add("r2",8);
        c5.DictDistanceToRegion.Add("r3",4);
        c5.DictDistanceToRegion.Add("r4",10);
        c5.DictDistanceToRegion.Add("r6",2);
        c5.DictDistanceToRegion.Add("r7",27);
        
        c6.DictDistanceToRegion.Add("r1",30);
        c6.DictDistanceToRegion.Add("r2",5);
        c6.DictDistanceToRegion.Add("r3",7);
        c6.DictDistanceToRegion.Add("r4",9);
        c6.DictDistanceToRegion.Add("r5",3);
        c6.DictDistanceToRegion.Add("r7",27);
        
        c6.DictDistanceToRegion.Add("r1",8);
        c6.DictDistanceToRegion.Add("r2",5);
        c6.DictDistanceToRegion.Add("r3",9);
        c6.DictDistanceToRegion.Add("r4",7);
        c6.DictDistanceToRegion.Add("r5",25);
        c6.DictDistanceToRegion.Add("r6",27);

        ListCenters = new List<Center>();
        
        ListCenters.Add(c1);
        ListCenters.Add(c2);
        ListCenters.Add(c3);
        ListCenters.Add(c4);
        ListCenters.Add(c5);
        ListCenters.Add(c6);
        ListCenters.Add(c7);
    }
}