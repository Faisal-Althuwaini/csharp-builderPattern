namespace ConsoleApp1;

public class Meal
{
    
    public string MainDish { get; set; }
    public string SideDish { get; set; }
    public string Drink { get; set; }
    public string Dessert { get; set; }
    public bool IsCombo { get; set; }

    private int CalculatePrice()
    {
        return (MainDish != null ? 20 : 0)
               + (SideDish != null ? 10 : 0)
               + (Drink != null ? 5 : 0)
               + (Dessert != null ? 8 : 0);
    }
    
    public override string ToString()
    {
        return $"Meal [Main={MainDish}, Side={SideDish}, Drink={Drink}, " +
               $"Dessert={Dessert}, Combo={IsCombo}, Price={CalculatePrice():C}]";
    }
    
    
}