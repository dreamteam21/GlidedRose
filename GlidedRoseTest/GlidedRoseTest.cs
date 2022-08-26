using GlidedRose.Item;
using NUnit.Framework;

namespace GlidedRoseTest;

public class GlidedRoseTest
{
    [TestCase(10,9)]
    [TestCase(15,14)]
    public void ShouldItemSellInDecreaseEveryDay(int sellIn, int expected_sellIn)
    {
        Item item = new Item();
        item.SellIn = sellIn;
        item.UpdateItem();
        Assert.That(item.SellIn, Is.EqualTo(expected_sellIn));
    }
    
    [TestCase(40,39)]
    [TestCase(13,12)]
    public void ShouldItemQualityDecreaseEveryDay(int quality, int expected_quality)
    {
        Item item = new Item();
        item.SellIn = 10;
        item.Quality = quality;
        item.UpdateItem();
        Assert.That(item.Quality, Is.EqualTo(expected_quality));
    }

    [TestCase(14,12)]
    [TestCase(9,7)]
    public void ShouldQualityDecreaseTwiceWhenSellDatePassed(int quality, int expected_quality)
    {
        Item item = new Item();
        item.SellIn = 0;
        item.Quality = quality;
        item.UpdateItem();
        Assert.That(item.Quality, Is.EqualTo(expected_quality));
    }

    [TestCase(10, 0, 0)]
    [TestCase(0,0, 0)]
    [TestCase(-5,0, 0)]
    public void ShouldQualityNeverBeNegative(int sellIn, int quality, int expected_quality)
    {
        Item item = new Item();
        item.SellIn = sellIn;
        item.Quality = quality;
        item.UpdateItem();
        Assert.That(item.Quality, Is.EqualTo(expected_quality));
    }

    [TestCase(10, 6, 7)]
    [TestCase(3,7, 8)]
    public void ShouldAgedBrieQualityIncreaseEveryDay(int sellIn, int quality, int expected_quality)
    {
        AgedBrie agedBrie = new AgedBrie();
        agedBrie.SellIn = sellIn;
        agedBrie.Quality = quality;
        agedBrie.UpdateItem();
        Assert.That(agedBrie.Quality, Is.EqualTo(expected_quality));
    }

    [TestCase(10, 50, 50)]
    [TestCase(0,50, 48)]
    [TestCase(-5,50, 48)]
    public void ShouldAgedBrieQualityNeverBeMoreThan50(int sellIn, int quality, int expected_quality)
    {
        AgedBrie agedBrie = new AgedBrie();
        agedBrie.SellIn = sellIn;
        agedBrie.Quality = quality;
        agedBrie.UpdateItem();
        Assert.That(agedBrie.Quality, Is.EqualTo(expected_quality));
    }
}
