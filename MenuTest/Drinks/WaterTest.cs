using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal(.1, w.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        //Has correct calories and price for small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal(.1, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        //Has correct calories and price for medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal(.1, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, w.Size);
        }

        //Has correct calories and price for large

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal(.1, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, w.Size);
        }

        //Checking that holds and adds work

        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        [Fact]
        public void AddIceShouldAddIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }


        //test ingredients list
        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Single(w.Ingredients);
        }

        [Fact]
        public void AddLemonShouldAddLemonToIngredients()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Contains<string>("Lemon", w.Ingredients);
            Assert.Equal<int>(2, w.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice");
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        [Fact]
        public void AddLemonShouldNotifyOfSpecialPropertyChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.AddLemon();
            });
        }
    }
}
