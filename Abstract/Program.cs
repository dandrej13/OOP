using Abstract;

Dog dog = new Dog();

Console.WriteLine("Insert a dog name: ");
dog.SetName(Console.ReadLine());

Console.WriteLine(dog.GetName());
dog.Eat();