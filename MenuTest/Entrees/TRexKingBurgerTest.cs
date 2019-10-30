using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldKetchup();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldBun();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldMustard()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldPickle()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldMayo()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldMayo();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mayo", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldLettuce();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldOnion();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldTomato()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldTomato();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Tomato", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldKetchupAndMustard()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldKetchup();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldBunAndPickle()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldBun();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldKetchupAndPickle()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldKetchup();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldMustardAndBun()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldBun();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            },
            item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldEverything()
        {
            TRexKingBurger s = new TRexKingBurger();
            s.HoldKetchup();
            s.HoldMustard();
            s.HoldBun();
            s.HoldPickle();
            s.HoldLettuce();
            s.HoldMayo();
            s.HoldOnion();
            s.HoldTomato();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            },
            item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            },
            item =>
            {
                Assert.Equal("Hold Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Mayo", item);
            },
            item =>
            {
                Assert.Equal("Hold Onion", item);
            },
            item =>
            {
                Assert.Equal("Hold Tomato", item);
            });
        }

        [Fact]
        public void TRexKingBurgerDescriptionShouldGiveName()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldMustard();
            });
        }

        [Fact]
        public void HoldMayoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldMayo();
            });
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldBun();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldPickle();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldLettuce();
            });
        }

        [Fact]
        public void HoldTomatoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldTomato();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger b = new TRexKingBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldOnion();
            });
        }
    }

}
