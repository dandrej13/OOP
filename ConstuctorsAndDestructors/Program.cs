using FirstClassAndMethodToString;

Person[] people = new Person[3];
Console.WriteLine($"Enter three different names and press enter after each of them!");
for (int i = 0; i < 3; i++)
{

    Person person = new Person(Console.ReadLine());

    people[i] = person;



}


Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Hello! my name is {people[i].ToString()}");
}
