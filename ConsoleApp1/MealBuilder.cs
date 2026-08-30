namespace ConsoleApp1;

public class MealBuilder
{
    private readonly Meal _meal = new Meal();

    public MealBuilder SetMainDish(string mainDish)
    {
        _meal.MainDish = mainDish;
        return this;
    }

    public MealBuilder SetSideDish(string sideDish)
    {
        _meal.SideDish = sideDish;
        return this;
    }

    public MealBuilder SetDrink(string drinkName)
    {
        _meal.Drink = drinkName;
        return this;
    }

    public MealBuilder SetDessert(string dessertName)
    {
        _meal.Dessert = dessertName;
        return this;
    }

    public MealBuilder SetIsCombo(bool isCombo)
    {
        _meal.IsCombo =  isCombo;
        return this;
    }

    public Meal Build()
    {
        return _meal;
    }
}