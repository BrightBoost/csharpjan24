namespace ExampleAppJan24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nameOfParticipant; // declare
            nameOfParticipant = "Martijn"; // initialise
            string name2 = "Marc"; // declare and initialise

            int numberOfStudents = 5;
            long bigNumberOfStudents = 1322342342342349999;
            double avgNrOfStudents = 4.7;
            float avgNrOfStudetns2 = 3.4f; // kleiner dan double
            decimal moneyValue = 3.4m;
            bool isFun = true;
            char character = 'a';

            Console.WriteLine("Wat is je naam? ");
            string name = Console.ReadLine();
            Console.WriteLine("Wat is je leeftijd? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De naam is zoveel chars: " + name.Length);
            double result = 4.0 / 5.0;

            Console.WriteLine(name + " " + age + " " + result);

            string voorbeeld = null; //prima
            //int x = null; //compileert niet
            int? x2 = null; //compileert wel, nu is het een nullable

            bool zelfde = age == 25;
            Console.WriteLine(zelfde);*/

            int nummer = 78;
            if (nummer > 0)
            {
                Console.WriteLine("Nummer is groter dan 0.");
            }
            else if (nummer % 2 != 0)
            {
                Console.WriteLine("Nummer is oneven.");
            }
            else if (nummer == 78)
            {
                Console.WriteLine("Nr is 78");
            }
            else
            {
                Console.WriteLine("Nummer is niet groter dan 0 en even.");
            }

        }
    }
}