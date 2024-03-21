// See https://aka.ms/new-console-template for more information

string[] students = { "Rasta", "Biggie G", "Calcus", "Edd", "Yakuza" };
int[] grades = { 95, 87, 74, 66, 58 };



bool exit = false;
while (!exit)
{
    Console.WriteLine("1. Display grades");
    Console.WriteLine("2. Display average");
    Console.WriteLine("3. Change grades");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option:");
    string select = (Console.ReadLine());

    if (select == "1")
    {

        Console.WriteLine(students[0] + " - " + grades[0] + "% (" + 
    }
    else if (select == "2")
    {

    }
    else if (select == "3")
    {

    }
    else if (select == "4")
    {
        exit = true;
        Console.WriteLine("Program exited.");
    }
    else
    {
        Console.WriteLine("An error occurred");
    }
}