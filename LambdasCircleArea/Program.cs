// See https://aka.ms/new-console-template for more information

// Asking the user to enter the radius of the circle 
Console.WriteLine("Please enter a radius: ");
int r = Convert.ToInt32(Console.ReadLine());

// Pi method
double pi = Math.PI;

// Double for pi
Console.WriteLine(pi);

// Lambda expression to calculate the area (pi * r^2)
Func<int, double> circleArea = (area) => pi * r * r;

// Print the final calculate using the expression
double calculateCircleArea = circleArea(r);
Console.WriteLine(calculateCircleArea);