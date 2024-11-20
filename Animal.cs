namespace Animal;

public class Animal
{
    public string Nickname { get; set; }

    public string Species { get; set; }

    public string DietType { get; set; }

    public int Age { get; set; }

    public string Gender { get; set; }

    public int Weight { get; set; }

    public int Height { get; set; }

    public string Color { get; set; }

    public string Habitat { get; set; }

    public void AnimalNickname()
    {
        Console.WriteLine($"Hayvon laqabi: {Nickname} ");
    }

    public void AnimalSpecies()
    {
        Console.WriteLine($"Hayvon turi:  {Species} ");
    }
}