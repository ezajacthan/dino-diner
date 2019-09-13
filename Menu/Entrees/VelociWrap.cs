using System;
using System.Collections.Generic;

public class VelociWrap
{
    private bool dressing = true;
    private bool lettuce = true;
    private bool cheese = true;
    
    public double Price { get; set; }
    public uint Calories { get; set; }

    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Flour Tortilla" };
            ingredients.Add("Chicken Breast");
            if (lettuce) ingredients.Add("Romaine Lettuce");
            if (dressing) ingredients.Add("Ceasar Dressing");
            if (cheese) ingredients.Add("Parmesan Cheese");
            return ingredients;
        }
    }

    public VelociWrap()
    {
        this.Price = 6.86;
        this.Calories = 356;
    }

    public void HoldLettuce()
    {
        this.lettuce = false;
    }

    public void HoldDressing()
    {
        this.dressing = false;
    }

    public void HoldCheese()
    {
        this.cheese = false;
    }

    
}
