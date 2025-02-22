﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;



namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal(.99, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.False(s.hasLemon);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSweetner()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.False(s.isSweet);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        //Has correct calories and price for small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Small;
            Assert.Equal(.99, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSmall()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Small;
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToSmall()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        //Has correct calories and price for medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            Assert.Equal(1.49, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            Assert.Equal<uint>(16, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        //Has correct calories and price for large

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            Assert.Equal(1.99, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            Assert.Equal<uint>(32, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, s.Size);
        }

        //Checking that holds and adds work
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Tyrannotea s = new Tyrannotea();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.hasLemon);
        }

        [Fact]
        public void SettingSweetShouldGetProperCaloriesForSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Small;
            t.AddSugar();
            Assert.Equal<uint>(16, t.Calories);
        }

        [Fact]
        public void SettingSweetShouldGetProperCaloriesForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.AddSugar();
            Assert.Equal<uint>(32, t.Calories);
        }

        [Fact]
        public void SettingSweetShouldGetProperCaloriesForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.AddSugar();
            Assert.Equal<uint>(64, t.Calories);
        }
        [Fact]
        public void ResettingSweetShouldGetProperCaloriesForSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Small;
            t.AddSugar();
            t.RemoveSugar();
            Assert.Equal<uint>(8, t.Calories);
        }

        [Fact]
        public void ResettingSweetShouldGetProperCaloriesForMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.AddSugar();
            t.RemoveSugar();
            Assert.Equal<uint>(16, t.Calories);
        }


        [Fact]
        public void ResettingSweetShouldGetProperCaloriesForLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.AddSugar();
            t.RemoveSugar();
            Assert.Equal<uint>(32, t.Calories);
        }

        //test ingredients list
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
            Assert.Equal<int>(2, t.Ingredients.Count);
        }

        [Fact]
        public void SettingSweetShouldGetProperIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSugar();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
            Assert.Contains<string>("Cane Sugar", t.Ingredients);
            Assert.Equal<int>(3, t.Ingredients.Count);
        }

        [Fact]
        public void ResettingSweetShouldGetProperIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSugar();
            t.RemoveSugar();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
            Assert.Equal<int>(2, t.Ingredients.Count);
        }

        [Fact]
        public void SettingLemonShouldGetProperIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
            Assert.Contains<string>("Lemon", t.Ingredients);
            Assert.Equal<int>(3, t.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void SpecialShouldMakeSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSugar();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Sweet", item);
            });
        }

        [Fact]
        public void SpecialShouldAddLemonAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            t.AddSugar();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Sweet", item);
            });
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.isSweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Fact]
        public void AddLemonShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.AddLemon();
            });
        }

        [Fact]
        public void AddSugarShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.AddSugar();
            });
        }

        [Fact]
        public void RemoveSugarShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.AddSugar();
                t.RemoveSugar();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SettingToSmallShouldNotifyOfDescriptionPropertyChange(Size size)
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SettingToSmallShouldNotifyOfPricePropertyChange(Size size)
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Price", () =>
            {
                t.Size = size;
            });
        }
    }
}
