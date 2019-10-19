﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal(.59, j.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.False(j.Ice);
        }

        
        [Fact]
        public void ShouldHaveCorrectDefaultCream()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.False(j.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, j.Size);
        }

        //Has correct calories and price for small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal(.59, j.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, j.Size);
        }

        //Has correct calories and price for medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurrasicJava s = new JurrasicJava();
            s.Size = Size.Medium;
            Assert.Equal(.99, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurrasicJava s = new JurrasicJava();
            s.Size = Size.Medium;
            Assert.Equal<uint>(4, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurrasicJava s = new JurrasicJava();
            s.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, s.Size);
        }

        //Has correct calories and price for large

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurrasicJava s = new JurrasicJava();
            s.Size = Size.Large;
            Assert.Equal(1.49, s.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurrasicJava s = new JurrasicJava();
            s.Size = Size.Large;
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurrasicJava s = new JurrasicJava();
            s.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, s.Size);
        }

        //Checking that holds and adds work
        
        [Fact]
        public void RoomForCreamShouldAddRoomForCream()
        {
            JurrasicJava t = new JurrasicJava();
            t.LeaveRoomForCream();
            Assert.True(t.RoomForCream);
        }

        [Fact]
        public void AddIceShouldAddIce()
        {
            JurrasicJava t = new JurrasicJava();
            t.AddIce();
            Assert.True(t.Ice);
        }


        //test ingredients list
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava t = new JurrasicJava();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Coffee", t.Ingredients);
            Assert.Equal<int>(2, t.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            JurrasicJava s = new JurrasicJava();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void SpecialShouldGveRoomForCream()
        {
            JurrasicJava j = new JurrasicJava();
            j.RoomForCream();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Room for Cream", item);
            });
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurrasicJava j = new JurrasicJava();
            j.AddIce();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void SpecialShouldMakeDecaf()
        {
            JurrasicJava j = new JurrasicJava();
            j.Decaf();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Decaf", item);
            });
        }

        [Fact]
        public void SpecialShouldGveRoomForCreamAndAddIce()
        {
            JurrasicJava j = new JurrasicJava();
            j.RoomForCream();
            j.AddIce();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Room for Cream", item);
            },
            item =>
            {
                Assert.Equal("Add Ice");
            });
        }

        [Fact]
        public void SpecialShouldGveRoomForCreamAndMakeDecaf()
        {
            JurrasicJava j = new JurrasicJava();
            j.RoomForCream();
            j.Decaf();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Room for Cream", item);
            },
            item =>
            {
                Assert.Equal("Decaf");
            });
        }

        [Fact]
        public void SpecialShouldGveRoomForCreamAndAddIceAndMakeDecaf()
        {
            JurrasicJava j = new JurrasicJava();
            j.RoomForCream();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Room for Cream", item);
            },
            item =>
            {
                Assert.Equal("Add Ice");
            },
            item =>
            {
                Assert.Equal("Decaf");
            });
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = size;
            java.decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }

    }
}
