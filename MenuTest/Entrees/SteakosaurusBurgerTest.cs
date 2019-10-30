using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldKetchup();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldMustard()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldPickle()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void SpecialShouldHoldKetchupAndMustard()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
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
            SteakosaurusBurger s = new SteakosaurusBurger();
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
            SteakosaurusBurger s = new SteakosaurusBurger();
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
        public void SpecialShouldHoldBunAndMustard()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
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
        public void SpecialShouldHoldKetchupAndMustardAndBunAndPickle()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldKetchup();
            s.HoldMustard();
            s.HoldBun();
            s.HoldPickle();
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
            });
        }

        [Fact]
        public void SteakosaurusBurgerDescriptionShouldGiveName()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger b = new SteakosaurusBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger b = new SteakosaurusBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldMustard();
            });
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger b = new SteakosaurusBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldBun();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger b = new SteakosaurusBurger();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldPickle();
            });
        }
    }

}
