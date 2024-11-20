using Animal;
public class Program
{
    public static void Main(string[] args)
    {
        Animal.Animal mushuk = new Animal.Animal()
        {
            Nickname = "Najim",
            Species = "Uy hayvoni",
            DietType = "Milk",
            Gender = "Male",
            Age = 2,
            Weight = 2,
            Height = 20,
            Color = "Narda gray",
            Habitat = "home"
        };
        mushuk.AnimalNickname();
        mushuk.AnimalSpecies();
        Console.WriteLine();
        Animal.Animal Lion = new Animal.Animal()
        {
            Nickname = "Lion",
            Species = "Yovvoyi hayvon",
            DietType = "Meat",
            Gender = "Male",
            Age = 5,
            Weight = 120,
            Height = 130,
            Color = "Golden yellow",
            Habitat = "Savanna"
        };
        Lion.AnimalNickname();
        Lion.AnimalSpecies();
        Console.WriteLine();
        Animal.Animal monkey = new Animal.Animal()
        {
            Nickname = "Monkey",
            Species = "Yovvoyi hayvon",
            DietType = "fruit",
            Gender = "female",
            Age = 3,
            Weight = 50,
            Height = 150,
            Color = "Brown",
            Habitat = "Jungle"
        };
        monkey.AnimalNickname();
        monkey.AnimalSpecies();
    }
}