namespace GlidedRose.Item;

public class Item
{
    public int SellIn
    {
        get => sellIn;
        set => sellIn = value;
    }

    public int sellIn;
    public int quality;

    public int Quality
    {
        get => quality;
        set => quality = value;
    }

    public Item(int sellIn = 0)
    {
        this.sellIn = sellIn;
    }

    public void UpdateItem()
    {
        if (this.SellIn <= 0)
        {
            this.Quality = Quality - 2;
        }
        else
        {
            this.Quality = Quality - 1;
        }

        if (this.Quality <= 0)
        {
            this.Quality = 0;
        }
        this.SellIn = SellIn - 1;
    }
}

public class AgedBrie : Item
{
    public void UpdateItem()
    {
        if (this.SellIn <= 0)
        {
            this.Quality = Quality - 2;
        }
        else
        {
            this.Quality = Quality + 1;
        }

        if (this.Quality <= 0)
        {
            this.Quality = 0;
        }
        
        if (this.Quality > 50)
        {
            this.Quality = 50;
        }
        
        this.SellIn = SellIn - 1;
    }
}

public class Sulfuras : Item
{
    public void UpdateItem(){}
}

public class BackstagePasses : Item
{
    public void UpdateItem()
    {
        if (this.SellIn <= 0)
        {
            this.Quality = Quality - 2;
        }
        else
        {
            this.Quality = Quality + 1;
        }

        if (this.Quality <= 0)
        {
            this.Quality = 0;
        }
        
        if (this.Quality > 50)
        {
            this.Quality = 50;
        }
        
        this.SellIn = SellIn - 1;
    }
}