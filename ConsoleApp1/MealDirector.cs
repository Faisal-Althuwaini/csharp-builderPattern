namespace ConsoleApp1;

public class MealDirector
{
    public Meal BuildKidsMeal()
    {
        return new MealBuilder()
            .SetMainDish("Chicken Nuggets")
            .SetSideDish("Apple Slices")
            .SetDrink("Apple Juice")
            .SetDessert("Cookie")
            .SetIsCombo(false)
            .Build();
    }
    
    public Meal BuildComboMeal()
    {
        return new MealBuilder()
            .SetMainDish("Burger")
            .SetSideDish("Fries")
            .SetDrink("Cola")
            .Build();
    }
    
    public Meal BuildCustomMeal()
    {
        var builder = new MealBuilder();

        Console.Write("Enter main dish (or leave blank): ");
        string mainDish = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(mainDish))
            builder.SetMainDish(mainDish);

        Console.Write("Enter side dish (or leave blank): ");
        string sideDish = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(sideDish))
            builder.SetSideDish(sideDish);

        Console.Write("Enter drink (or leave blank): ");
        string drink = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(drink))
            builder.SetDrink(drink);

        Console.Write("Enter dessert (or leave blank): ");
        string dessert = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(dessert))
            builder.SetDessert(dessert);

        Console.Write("Make it a combo? (y/n): ");
        string comboInput = Console.ReadLine();
        bool isCombo = comboInput?.Trim().ToLower() == "y";
        builder.SetIsCombo(isCombo);

        return builder.Build();
    }


}
