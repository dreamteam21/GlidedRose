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

    [TestCase(10,5,10,5)]
    [TestCase(0,5,0,5)]
    [TestCase(-21,5,-21,5)]
    public void ShouldSulfurasNeverDecrease(int sellIn, int quality, int expected_sellIn, int expected_quality)
    {
        Sulfuras sulfuras = new Sulfuras();
        sulfuras.SellIn = sellIn;
        sulfuras.Quality = quality;
        sulfuras.UpdateItem();
        Assert.That(sulfuras.SellIn, Is.EqualTo(expected_sellIn));
        Assert.That(sulfuras.Quality, Is.EqualTo(expected_quality));
    }

    [TestCase(11,5,6)]
    [TestCase(14,31,32)]
    public void ShouldBackstagePassIncreaseBy1WhenSellInMoreThan10Days(int sellIn, int quality, int expected_quality)
    {
        BackstagePasses backstagePasses = new BackstagePasses();
        backstagePasses.SellIn = sellIn;
        backstagePasses.Quality = quality;
        backstagePasses.UpdateItem();
        Assert.That(backstagePasses.Quality, Is.EqualTo(expected_quality));
    }
    
    [TestCase(8,9,11)]
    [TestCase(6,30,32)]
    [TestCase(10,49,50)]
    public void ShouldBackstagePassIncreaseBy2WhenSellInBetween6To10Days(int sellIn, int quality, int expected_quality)
    {
        BackstagePasses backstagePasses = new BackstagePasses();
        backstagePasses.SellIn = sellIn;
        backstagePasses.Quality = quality;
        backstagePasses.UpdateItem();
        Assert.That(backstagePasses.Quality, Is.EqualTo(expected_quality));
    }
    
    [TestCase(5,13,16)]
    [TestCase(4,4,7)]
    [TestCase(3,48,50)]
    public void ShouldBackstagePassIncreaseBy3WhenSellInLessThan6Days(int sellIn, int quality, int expected_quality)
    {
        BackstagePasses backstagePasses = new BackstagePasses();
        backstagePasses.SellIn = sellIn;
        backstagePasses.Quality = quality;
        backstagePasses.UpdateItem();
        Assert.That(backstagePasses.Quality, Is.EqualTo(expected_quality));
    }
    
    [TestCase(0,13,0)]
    [TestCase(-10,4,0)]
    [TestCase(-5,48,0)]
    public void ShouldBackstagePassBe0AfterTheConcert(int sellIn, int quality, int expected_quality)
    {
        BackstagePasses backstagePasses = new BackstagePasses();
        backstagePasses.SellIn = sellIn;
        backstagePasses.Quality = quality;
        backstagePasses.UpdateItem();
        Assert.That(backstagePasses.Quality, Is.EqualTo(expected_quality));
    }
    [TestCase(11,5,3)]
    [TestCase(0,5,1)]
    [TestCase(0,3,0)]
    public void ShouldConjuredDecreaseByTwice(int sellIn, int quality, int expected_quality)
    {
        Conjured conjured = new Conjured();
        conjured.SellIn = sellIn;
        conjured.Quality = quality;
        conjured.UpdateItem();
        Assert.That(conjured.Quality, Is.EqualTo(expected_quality));
    }
}


