class Person{

    //fields
    string name;
    int age;
}
class Program{
    public static void Main(string[] args){
        Person person1 = new Person();
        person1.name = "Alice";
        person1.age = 30;
        Console.WriteLine("Name: " + person1.name);
        Console.WriteLine("Age: " + person1.age);
    }
}