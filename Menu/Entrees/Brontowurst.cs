using System;
using System.Collections.Generic;

public class Brontowurst
{
    //backing variables
    private bool bun = true;
    private bool peppers = true;
    private bool onions = true;

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
            List<string> ingredients = new List<string>() { "Brautwurst" };
            if (peppers) ingredients.Add("Peppers");
            if (onions) ingredients.Add("Onion");
            if (bun) ingredients.Add("Whole Wheat Bun");
            return ingredients;
        }
    }

    /// <summary>
    /// Constructs a new object of the Brontowurst with the default price and calories
    /// </summary>
    public Brontowurst()
    {
        this.Price = 5.36;
        this.Calories = 498;
    }

    /// <summary>
    /// Sets the object such that there are no peppers 
    /// </summary>
    public void HoldPeppers()
    {
        this.peppers = false;
    }

    /// <summary>
    /// Sets the object such that there are no onions
    /// </summary>
    public void HoldOnion()
    {
        this.onions = false;
    }

    /// <summary>
    /// Sets the object such that there is no bun
    /// </summary>
    public void HoldBun()
    {
        this.bun = false;
    }
}
