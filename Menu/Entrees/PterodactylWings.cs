using System;
using System.Collections.Generic;

public class PterodactylWings
{
    /// <summary>
    /// Gets and sets the price
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Gets and sets the calories
    /// </summary>
    public uint Calories { get; set; }

    /// <summary>
    /// Gets the list of ingredients
    /// </summary>
    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Chicken" };
            ingredients.Add("Wing Sauce");
            return ingredients;
        }
    }

    /// <summary>
    /// Constructs an object of the PterodactylWings with default price and calories
    /// </summary>
    public PterodactylWings()
    {
        this.Price = 7.21;
        this.Calories = 318;
    }

}