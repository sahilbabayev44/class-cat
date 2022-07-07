namespace program_MERCEDES
{
     class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("rex", "yellow", 2);
            dog.name = "rex";
            dog.color = "yellow";
            dog.age = 2;
            Console.WriteLine($"{dog.name} {dog.color} {dog.age}");

            Console.WriteLine(dog.GetDetalis());

        }
    }
}