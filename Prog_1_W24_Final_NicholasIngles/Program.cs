// See https://aka.ms/new-console-template for more information

string[] students = { "Rasta", "Biggie G", "Calcus", "Edd", "Yakuza" };//Setting variables
double[] percentages = { 95, 87, 74, 66, 58 };
string[] grades = new string[5];
bool exit = false;

while (!exit)//Loops program until exited
{
    Console.WriteLine("\n1. Display grades");//Main menu
    Console.WriteLine("2. Display average");
    Console.WriteLine("3. Change grades");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option: ");
    string mainselect = Console.ReadLine();//User input
    Console.WriteLine("\n");

    if (mainselect == "1")//Option 1 selected
    {
        for (int i = 0; i < grades.Length; i++)//Assigns each percent grade a letter grade in a simple loop
        {
            if (percentages[i] >= 90)
            {
                grades[i] = "A";
            }
            else if (percentages[i] >= 80)
            {
                grades[i] = "B";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "C";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "D";
            }
            else
            {
                grades[i] = "F";
            }
        }

        Console.WriteLine(students[0] + " - " + percentages[0] + "% (" + grades[0] + ")");//Displaying grades
        Console.WriteLine(students[1] + " - " + percentages[1] + "% (" + grades[1] + ")");
        Console.WriteLine(students[2] + " - " + percentages[2] + "% (" + grades[2] + ")");
        Console.WriteLine(students[3] + " - " + percentages[3] + "% (" + grades[3] + ")");
        Console.WriteLine(students[4] + " - " + percentages[4] + "% (" + grades[4] + ")");
    }
    else if (mainselect == "2")//Option 2 selected
    {
        double average = (percentages[0] + percentages[1] + percentages[2] + percentages[3] + percentages[4]) / 5;//Calculates average percent grade
        string averagegrade = (grades[0]);

        if (average >= 90)//Determines letter grade associated with average percent grade
        {
            averagegrade = "A";
        }
        else if (average >= 80)
        {
            averagegrade = "B";
        }
        else if (average >= 70)
        {
            averagegrade = "C";
        }
        else if (average >= 60)
        {
            averagegrade = "D";
        }
        else
        {
            averagegrade = "F";
        }

        Console.WriteLine("Average grade: " + average + "% (" + averagegrade + ")");//Displays average
    }
    else if (mainselect == "3")//Option 3 selected
    {
        Console.WriteLine("1. Rasta");//Student select menu
        Console.WriteLine("2. Biggie G");
        Console.WriteLine("3. Calcus");
        Console.WriteLine("4. Edd");
        Console.WriteLine("5. Yakuza");
        Console.Write("Select student: ");
        string select = Console.ReadLine();//User input
        Console.Write("Enter new percent grade: ");
        string newgrade = Console.ReadLine();//User input
        Console.WriteLine("\n");

        try//Try for Parsing
        {
            if (select == "1")//parsing user input
            {
                percentages[0] = double.Parse(newgrade);
                Console.WriteLine("Grade changed successfully");
            }
            else if (select == "2")
            {
                percentages[1] = double.Parse(newgrade);
                Console.WriteLine("Grade changed successfully");
            }
            else if (select == "3")
            {
                percentages[2] = double.Parse(newgrade);
                Console.WriteLine("Grade changed successfully");
            }
            else if (select == "4")
            {
                percentages[3] = double.Parse(newgrade);
                Console.WriteLine("Grade changed successfully");
            }
            else if (select == "5")
            {
                percentages[4] = double.Parse(newgrade);
                Console.WriteLine("Grade changed successfully");
            }
            else
            {
                Console.WriteLine("\nAn error occurred\n");//Invalid input notification
            }
        }
        catch//Error catch
        {
            Console.WriteLine("\nAn error occurred\n");//Invalid input notification
        }
    }
    else if (mainselect == "4")//Option 4 selected
    {
        exit = true;//Exits program
        Console.WriteLine("\nProgram exited.");
    }
    else
    {
        Console.WriteLine("\nAn error occurred\n");//Invalid input notification
    }
}