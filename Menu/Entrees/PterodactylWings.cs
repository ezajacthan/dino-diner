using System;

public class PterodacytlWings
{
    public double Price { get; set; }
    public uint Calories { get; set; }

    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Chicken" };
            ingredients.Add("Wing Sauce");
            return ingredients;
        }
    }

    public Brontowurst()
    {
        this.Price = 7.21;
        this.Calories = 318;
    }

}