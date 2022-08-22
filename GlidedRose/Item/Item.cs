namespace GlidedRose.Item;

public class Item
{
    public int SellIn
    {
        get => sellIn;
        set => sellIn = value;
    }

    public int sellIn;

    public Item(int sellIn = 0)
    {
        this.sellIn = sellIn;
    }

    public void UpdateItem()
    {
        this.SellIn = sellIn - 1;
    }
}