using GlidedRose.Item;
using TechTalk.SpecFlow;

namespace Specflow.test.Steps;

[Binding]
public class UpdateItem
{
    private Item item = new Item();
    [Given(@"the item SellIn is (.*)")]
    public void GivenTheItemSellInIs(int p0)
    {
        item.SellIn = p0;
    }

    [When(@"the day is passed")]
    public void WhenTheDayIsPassed()
    {
        item.UpdateItem();
    }

    [Then(@"the item SellIn should be (.*)")]
    public void ThenTheItemSellInShouldBe(int p0)
    {
        Assert.That(item.SellIn, Is.EqualTo(p0));
    }
}