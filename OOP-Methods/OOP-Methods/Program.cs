internal class Program
{
    private static void Main(string[] args)
    {
        // Functions or Methods

        // Why We Use Functions
        // DRY: dont repeat yourself

        // my average 
        double sub1 = 90;
        double sub2 = 80;
        double avg = (sub1 + sub2) / 2;
        Console.WriteLine("Ammar's Avg: " + avg);

        // Ahmad's average
        double subject1 = 98;
        double subject2 = 75;
        double ahmadAvg = (subject1 + subject2) / 2;
        Console.WriteLine("Ahmad's Avg: " + ahmadAvg);

        //khalid average
        double subj1 = 80;
        double subj2 = 60;
        double khalidAverage = (subj1 + subj2) / 2;
        Console.WriteLine("khalid's Average: " + khalidAverage);
        Console.WriteLine("---------------------------------");

        // Average Function
        // Syntax = [Modifier] [Return Type] [Function Name] (Parameters){}
        // don't return anything [void]
        void findAvg(string name, double sub1, double sub2) // Parameters: is the variable in the declaration of the function
        {
            double avg = (sub1 + sub2) / 2;
            Console.WriteLine(name + "'s avg: " + avg);
        }
        // Calling Method
        findAvg("Ammar", 90, 80); // Arguments: the actual values of this variable
        findAvg("Ahmad", 98, 75);
        findAvg("Khalid", 80, 60);
        Console.WriteLine("---------------------------------");


        // Passing By Referance VS Passing By Value
        void addTwo(ref int x,ref int y)
        {
            x = x + 1; // 3
            y = y + 1; // 3
            Console.WriteLine("x + y = " + (x + y));
        }
        int first = 2; // 2 + 1
        int second = 2; // 2 + 1
        addTwo(ref first, ref second); // arguments: values
        Console.WriteLine("first = " + first + "\n" + "second = " + second);






    }
}