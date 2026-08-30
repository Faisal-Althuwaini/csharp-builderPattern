using ConsoleApp1;


var m1 = new MealBuilder()
    .SetMainDish("Chicken Nuggets") // 20
    .SetSideDish("Apple Slices") // 10
    .Build();

Console.WriteLine(m1.ToString());

var m2 = new MealBuilder()
    .SetMainDish("Chicken Burger")
    .SetSideDish("Fries")
    .SetDrink("Cola")
    .SetDessert("Cookies")
    .Build();

Console.WriteLine(m2.ToString());

var m3 = new MealDirector()
    .BuildComboMeal();

Console.WriteLine(m3.ToString());

Console.WriteLine("============================");
var custom = new MealDirector().BuildCustomMeal();
Console.WriteLine(custom.ToString());
    







