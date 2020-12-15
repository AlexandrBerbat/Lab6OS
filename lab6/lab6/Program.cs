using System;


public class Program{ 
	static void Main(string[] args)
{
	Console.WriteLine("Inside main()");
	string typeOfShape = Console.ReadLine();
	int i = 0;
	for (; i < 0xffffff; i++) ;
	switch (typeOfShape)
	{
		case "dog":
			DrawDog();
			break;
		case "cat":
			DrawCat();
			break;
	}
}
static void DrawCat()
{
	for (int i = 0; i < 1000000000; i++)
	{
		//process of drawing
	}

}
static void DrawDog()
{
	for (int i = 0; i < 1000000000; i++)
	{
		//process of drawing
	}
}
}

