using GlidedRose.Item;
using NUnit.Framework;

namespace GlidedRoseTest;

public class GlidedRoseTest
{
    [Test]
    public void ShouldHaveItemSellInProperty()
    {
        Item item = new Item();
        item.SellIn = 10;
        Assert.That(item.SellIn, Is.EqualTo((10)));
    }
}