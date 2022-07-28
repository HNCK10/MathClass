// See https://aka.ms/new-console-template for more information
double x = 3.14;
//First useful method is the pow method
//Which will raise a variable to a certain power
double a = Math.Pow(x, 2);
double b = Math.Pow(x, 3);
Console.WriteLine(a + " is " + x + " to the power of 2 and " + b + " is " + x+ " to the power of 3");
//-----------------------------------------------------------------------------------------------------
//Next is the sqrt method, square root
double r = Math.Sqrt(x);
Console.WriteLine(r);
//--------------------------------------------------------
//Next is the absolute value or ABS
//Which is how far away something is from zero
//so if we have a negative number like -3
//It will result in a positive 3
double w = -3;
double e = Math.Abs(w);
Console.WriteLine(e);
//--------------------------------------------------------------------
//Next is the round function
double c=Math.Round(x);
Console.WriteLine(c);
//-----------------------------------
//Next is how to always round a number up
//It is known as the ceiling function
//So here, 3.14 rounded up is 4
double z = Math.Ceiling(x);
Console.WriteLine(z);
//-------------------------------------------
//Next is how to always round a number down
//It is known as the floor method
double q = Math.Floor(x);
Console.WriteLine(q);
//--------------------------------------------
//Next we have the max method, to find the maximum
//value of two values or variables
double y = 5;
double g = Math.Max(x, y);
Console.WriteLine(g);
//You can see the maximum is 5
//-----------------------------------------------
//We also have a min function
double s = 0.1;
double r = Math.Min(x, s);
Console.WriteLine(r);
//This will display 0.1 since it is smaller than 3.14
//----------------------------------------------------
Console.ReadKey();
