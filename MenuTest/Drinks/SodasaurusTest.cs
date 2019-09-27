﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //Can set each flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, s.Flavor);
        }

        //Has correct defaults
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal(1.5, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<uint>(112, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.True(s.Ice);
        }

        //Has correct calories and price for small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal(1.5, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<uint>(112, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        //Has correct calories and price for medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal(2, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal<uint>(156, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        //Has correct calories and price for large

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal(2.5, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<uint>(208, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, s.Size);
        }

        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }
    }
}