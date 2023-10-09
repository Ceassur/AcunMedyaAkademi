namespace InterfaceExcample
{
    internal class Program
    {
        // Interface içindeki bütün methodları implamante etmek zorundasın.
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
        interface IAnimal
        {
            void animalSound(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        class Pig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }


    }
}
