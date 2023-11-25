using DomaciUkol_8Lekce_farma;

List<Animal> animals = new List<Animal>();

Cow cow = new Cow() { Type = "Kráva", Gender = "female", Age = 5, Weight = 700};
animals.Add(cow);
Pig pig = new Pig() { Type = "Prase", Gender = "male", Age = 3, Weight = 100};
animals.Add(pig);
Chicken chicken = new Chicken() { Type = "Slepice", Gender = "female", Age = 1, Weight = 2};
animals.Add(chicken);

foreach (var a in animals)
{
    Console.WriteLine($"Já jsem { a.Type}, je mi {a.Age} let, dělám { a.Sound()}, {a.LookAtSky()} a {a.Food()}" );
}