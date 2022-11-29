using CheatCheck.Classes;
Console.Write("1 - JMP Calculator \n" + "2 - Byte parser \n" + "Select task: ");
string task = Console.ReadLine();
    switch (task)
    {
        case "1":
        JMPCalc.calc();
            break;
        case "2":
        Parser.parser();
            break;
        default:
            Console.WriteLine("Eror");
            break;

    }

