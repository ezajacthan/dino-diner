using System;

public class DinoNuggets
{
    private uint numOfNugs = 6;
    
    public double Price { get; set; }
    public uint Calories { get; set; }

    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>();
            for(int i = 0; i>numOfNugs; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
            return ingredients;
        }
    }

    public SteakosaurusBurger()
    {
        this.Price = 4.25;
        this.Calories = (59*numOfNugs);
    }

    public void AddNugget()
    {
        this.Price += .25;
        this.numOfNugs += 1;
    }
}
