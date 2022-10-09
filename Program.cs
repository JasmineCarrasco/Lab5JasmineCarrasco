void cat()
{
    Console.WriteLine("MEOW");
    Console.WriteLine($"(=^･ｪ･^=)");
}
void data()
{
    Console.WriteLine("Enter any number from 0 to infinity");
    int number = Convert.ToInt32(Console.ReadLine());
    menu();
}
void AddTwoNum()
{
    Console.WriteLine("Enter two numbers you would like to add.");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine(sum);
    Console.ReadKey();
    menu();
}

void SubTwoNum()
{
    Console.WriteLine("Enter two numbers you would like to subtract.");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int difference = num1 - num2;
    Console.WriteLine(difference);
    Console.ReadKey();
    menu();
}
void MultiTwoNum()
{
    Console.WriteLine("Enter two numbers you would like to multiply.");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int product = num1 * num2;
    Console.WriteLine(product);
    Console.ReadKey();
    menu();
}

void DivideTwoNum()
{
    Console.WriteLine("Enter two numbers you would like to divide.");
    decimal num1 = decimal.Parse(Console.ReadLine());
    decimal num2 = decimal.Parse(Console.ReadLine());
    decimal qoutient = num1 / num2;
    Console.WriteLine(qoutient);
    Console.ReadKey();
    menu();
}





void menu()
{
    Console.WriteLine("Welcome, what would you like to do, 1.Surpise me, 2.Enter a Number, 3. Add two numbers together, 4.Subtract two numbers together, 5.Multiply two numbers together, 6. Divide two numbers togther, 7.End or quit.");
    string response = Console.ReadLine();
    if (response == "1")
        cat();
    if (response == "2")
        data();
    if (response == "3")
        AddTwoNum();
    if (response == "4")
        SubTwoNum();
    if (response == "5")
        MultiTwoNum();
    if (response == "6")
        DivideTwoNum();
    if (response == "7")
    {
        Console.WriteLine("Goodbye!");
        System.Environment.Exit(0);

    }
    else
    {
        menu();
    }


}
menu();