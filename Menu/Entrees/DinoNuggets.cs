using System;
using System.Collections.Generic;


public class DinoNuggets
{
    //backing variable
    private uint numOfNugs = 6;
    
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
            List<string> ingredients = new List<string>();
            for(int i = 0; i<numOfNugs; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
            return ingredients;
        }
    }

    /// <summary>
    /// Constructs an object of the dino nuggets with the default price, nugget count and calories
    /// </summary>
    public DinoNuggets()
    {
        this.Price = 4.25;
        this.Calories = (59*numOfNugs);
        numOfNugs = 6;
    }

    /// <summary>
    /// Adds a nugget to the order and changes price and calorie count accordingly
    /// </summary>
    public void AddNugget()
    {
        this.Price += .25;
        this.numOfNugs += 1;
        this.Calories += 59;
    }
}
