// Using csharppad.com, create an "Animal" Class. 
// Base class
public class Animal {
// Your Animal class should include a Public string "AnimalName" that acts as a getter and a setter.
    public string AnimalName { get; set; }
    
}
// Create a "Species" Class that inherits from the "Animal" Class. 
// Derived class
public class Species : Animal {
//The Species class should include a public string "SpeciesName" that acts as a getter and a setter.
    public string SpeciesName { get; set; }
    
}

// Create three or more different classes for individual animals you want to include in your zoo. Each individual animal class should inherit from "species" and should include a public string with getter and setter for "Noise". You should also include 3-4 more getter/setters of your own choosing. Try and use at least one int (integer) type and one bool (boolean).

public class Lion : Species {
    public string Noise { get; set; }
    public string FavoriteFood { get; set; }
    public int Legs { get; set; }
    public bool IsMammal { get; set; }
    public bool HasMane { get; set; }
}    
public class Snake : Species {
    public string Noise { get; set; }
    public string FavoriteFood { get; set; }
    public int Legs { get; set; }
    public bool IsMammal { get; set; }
    public bool IsVenomous { get; set; }
}    
public class Bird : Species {
    public string Noise { get; set; }
    public string FavoriteFood { get; set; }
    public int Legs { get; set; }
    public bool IsMammal { get; set; }
    public bool CanFly { get; set; }
}


Lion Simba = new Lion();
// Set AnimalName, SpeciesName, Noise, and the other properties on the instance of your animal.
Simba.SpeciesName = "African";
Simba.Noise = "RAAAAR";
Simba.FavoriteFood = "Gazelle meat";
Simba.Legs = 4;
Simba.IsMammal = true;
Simba.HasMane = true;

// Use Console.write(); to display the properties of your animal to the console.
Console.WriteLine("I have a {0} Lion named Simba who makes a noise that sounds like {1}! His favorite food is {2}. He has {3} legs. It is {4} that he is a mammal and {5} that he has a mane.", Simba.SpeciesName, Simba.Noise, Simba.FavoriteFood, Simba.Legs, Simba.IsMammal, Simba.HasMane);

Snake Jake = new Snake();
// Set AnimalName, SpeciesName, Noise, and the other properties on the instance of your animal.
Jake.SpeciesName = "Garter";
Jake.Noise = "HISSSSSS";
Jake.FavoriteFood = "crickets";
Jake.Legs = 0;
Jake.IsMammal = false;
Jake.IsVenomous = false;

// Use Console.write(); to display the properties of your animal to the console.
Console.WriteLine("I have a {0} Snake named Jake who makes a noise that sounds like {1}! His favorite food is {2}. He has {3} legs. It is {4} that he is a mammal and {5} that he is venomous.", Jake.SpeciesName, Jake.Noise, Jake.FavoriteFood, Jake.Legs, Jake.IsMammal, Jake.IsVenomous);

Bird Kevin = new Bird();
// Set AnimalName, SpeciesName, Noise, and the other properties on the instance of your animal.
Kevin.SpeciesName = "Leghorn Chicken";
Kevin.Noise = "CLUCK, CLUCK";
Kevin.FavoriteFood = "seeds";
Kevin.Legs = 2;
Kevin.IsMammal = true;
Kevin.CanFly = false;

// Use Console.write(); to display the properties of your animal to the console.
Console.WriteLine("I have a {0} Bird named Kevin who makes a noise that sounds like {1}! His favorite food is {2}. He has {3} legs. It is {4} that he is a mammal and {5} that he can fly.", Kevin.SpeciesName, Kevin.Noise, Kevin.FavoriteFood, Kevin.Legs, Kevin.IsMammal, Kevin.CanFly);