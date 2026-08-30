namespace ConsoleApp1;

public class Car
{
    
    public string Name { get; set; }
    public string Engine { get; set; } = "V8";
    public string Color { get; set; }
    public bool WithSunRoof { get; set; }
    
    public override string ToString()
    {
        return $"Car [Engine={Engine}, Color={Color}, SunRoof={WithSunRoof},  Name={Name}]";
    }
    
}