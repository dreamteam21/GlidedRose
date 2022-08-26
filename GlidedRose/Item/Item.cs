using System.Reflection;

namespace GlidedRose.Item;

public class Item
{
    public String name;
    public int sellIn;
    public int quality;
    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
    public int SellIn
    {
        get => sellIn;
        set => sellIn = value;
    }
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
    public void UpdateItem()
    {
        this.SellIn = this.SellIn;
        this.Quality = this.Quality;
    }
}

public class BackstagePasses : Item
{
    public void UpdateItem()
    {
        if (this.SellIn <= 0)
        {
            this.Quality = 0;
        }
        else
        {
            if (this.SellIn <= 10 && this.SellIn > 5)
            {
                this.Quality = Quality + 2;
            }
            else if (this.SellIn <= 5 && this.SellIn >= 0)
            {
                this.Quality = Quality + 3;
            }
            else
            {
                
                this.Quality = Quality + 1;
            }
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

public class Conjured : Item
{
    public void UpdateItem()
    {
        if (this.SellIn <= 0)
        {
            this.Quality = Quality - 4;
        }
        else
        {
            this.Quality = Quality - 2;
        }

        if (this.Quality <= 0)
        {
            this.Quality = 0;
        }
        this.SellIn = SellIn - 1;
    }
}