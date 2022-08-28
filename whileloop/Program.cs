double fvalue, svalue;
char choice, oprator;



Console.WriteLine("Did You Want to use calculator?"+Environment.NewLine + "Press Y to Continue or press any key to close");
choice = Console.ReadKey().KeyChar;

while (choice == 'y' || choice == 'Y')
{
	Console.WriteLine("enter first value");
	fvalue = Convert.ToDouble(Console.ReadLine());

	Console.WriteLine("enter operator");
	oprator = Console.ReadKey().KeyChar;
	Console.WriteLine();

Console.WriteLine("enter second value");
	svalue = Convert.ToDouble(Console.ReadLine());

	if(oprator=='+')
	{
		Console.WriteLine("Reault:"+Convert.ToDouble(fvalue+svalue));
	}

	else if (oprator == '-')
	{
		Console.WriteLine("Reault:" + Convert.ToDouble(fvalue-svalue));
	}

	else if (oprator == '*')
	{
		Console.WriteLine("Reault:" + Convert.ToDouble(fvalue*svalue));
	}

	else  if (oprator == '/')
	{
		Console.WriteLine("Reault:" + Convert.ToDouble(fvalue/svalue));
	}

	else
	{
		Console.WriteLine("Wrong Command");
	}

	Console.WriteLine("Did You Want to use calculator?" + Environment.NewLine + "Press Y to Continue or press any key to close");
	choice = Console.ReadKey().KeyChar;
}
Console.WriteLine("Closed");
