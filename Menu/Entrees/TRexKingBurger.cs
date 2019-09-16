﻿using System;
using System.Collections.Generic;


public class TRexKingBurger
{
    //backing variables
    private bool bun = true;
    private bool lettuce = true;
    private bool tomato = true;
    private bool pickle = true;
    private bool onion = true;
    private bool ketchup = true;
    private bool mustard = true;
    private bool mayo = true;

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
            List<string> ingredients = new List<string>() { "Steakburger Pattie" };
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            if (lettuce) ingredients.Add("Lettuce");
            if (onion) ingredients.Add("Onion");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (tomato) ingredients.Add("Tomato");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            if (mayo) ingredients.Add("Mayo");
            return ingredients;
        }
    }

    /// <summary>
    /// Constructs an object of the TRexKingBurger with default calories and price
    /// </summary>
    public TRexKingBurger()
    {
        this.Price = 8.45;
        this.Calories = 728;
    }

    /// <summary>
    /// Sets the object such that there is no lettuce
    /// </summary>
    public void HoldLettuce()
    {
        this.lettuce = false;
    }

    /// <summary>
    /// Sets the object such that there is no onion
    /// </summary>
    public void HoldOnion()
    {
        this.onion = false;
    }

    /// <summary>
    /// Sets the object such that there is no bun
    /// </summary>
    public void HoldBun()
    {
        this.bun = false;
    }

    /// <summary>
    /// Sets the object such that there is no tomato
    /// </summary>
    public void HoldTomato()
    {
        this.tomato = false;
    }

    /// <summary>
    /// Sets the object such that there is no pickle
    /// </summary>
    public void HoldPickle()
    {
        this.pickle = false;
    }

    /// <summary>
    /// Sets the object such that there is no ketchup
    /// </summary>
    public void HoldKetchup()
    {
        this.ketchup = false;
    }

    /// <summary>
    /// Sets the object such that there is no mustard
    /// </summary>
    public void HoldMustard()
    {
        this.mustard = false;
    }

    /// <summary>
    /// Sets the object such that there is no mayo
    /// </summary>
    public void HoldMayo()
    {
        this.mayo = false;
    }
}
