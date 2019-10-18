using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;


namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }

        [Fact]
        public void SpecialShouldHoldPeppers()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldOnions()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Onions", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldPeppersAndOnions()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            b.HoldOnion();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            },
            item =>
            {
                Assert.Equal("Hold Onions", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldPeppersAndBun()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            b.HoldBun();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            },
            item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldBunAndOnions()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldOnion();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Onions", item);
            },
            item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldPeppersAndOnionAndBun()
        { 
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            b.HoldOnion();
            b.HoldBun();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            },
            item =>
            {
                Assert.Equal("Hold Onions", item);
            },
            item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void BrontowurstDescriptionShouldGiveName()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }
    }

}
