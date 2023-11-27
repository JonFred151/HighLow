


namespace favoriteSubject
{


    internal class program
    {

        public static void Main(string[] args)
        {
            string subject;

            Console.WriteLine("What is your favorite subject of these option. \nMath \nEnglish \nScience \nHistory \nLunch");
            subject = Console.ReadLine();
            switch (subject)
            {
                case "Math" or "math":
                    Console.WriteLine("Favorite Subject is Math");
                    break;
                case "English" or "english" :
                    Console.WriteLine("Favorite Subject is English");
                    break;
                case "Science" or "science":
                    Console.WriteLine("Favorite Subject is Science");
                    break;
                case "History" or "history":
                    Console.WriteLine("Favorite Subject is History");
                    break;
                case "Lunch" or "lunch":
                    Console.WriteLine("Favorite Subject is Lunch");
                    break;

            }









        }



    }






}




