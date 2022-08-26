using GlidedRose.Item;
class Run
{
    static void Main(string[] args)
    {
        List<Item> item = new List<Item>();
        AgedBrie agedBrie = new AgedBrie();
        agedBrie.Name = "Aged Brie";
        agedBrie.SellIn = 15;
        agedBrie.Quality = 10;
        Sulfuras sulfuras = new Sulfuras();
        sulfuras.Name = "Sulfuras";
        sulfuras.SellIn = 14;
        sulfuras.Quality = 20;
        BackstagePasses backstagePasses = new BackstagePasses();
        backstagePasses.Name = "Backstage Passes";
        backstagePasses.SellIn = 11;
        backstagePasses.Quality = 10;
        Conjured conjured = new Conjured();
        conjured.Name = "Conjured";
        conjured.SellIn = 19;
        conjured.Quality = 15;
        item.Add(agedBrie);
        item.Add(sulfuras);
        item.Add(backstagePasses);
        item.Add(conjured);
        for (int i = 0; i < 30; i++)
        {
            System.Console.WriteLine("Day "+(i+1));
            // foreach (var anItem in item)
            // {
            //     System.Console.WriteLine("Name: "+anItem.Name+", SellIn: "+anItem.SellIn+", Quality: "+anItem.Quality);
            //     anItem.UpdateItem();
            // }
            System.Console.WriteLine("Name: "+agedBrie.Name+", SellIn: "+agedBrie.SellIn+", Quality: "+agedBrie.Quality);
            agedBrie.UpdateItem();
            System.Console.WriteLine("=================================================================================");
        }
    }
}

