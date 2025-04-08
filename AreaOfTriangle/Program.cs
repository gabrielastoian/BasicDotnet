//program that calculates the area of a triangle given the base and height

//prompt the user for the base and height of the triangle
Console.WriteLine("What is the base of the triangle?");
var baseLength = Console.ReadLine();
Console.WriteLine("What is the height of the triangle?");
var height = Console.ReadLine(); 

//parse the input to a double
double baseLengthDouble = double.Parse(baseLength);
double heightDouble = double.Parse(height);

//calculate the area of the triangle
double areaOfTriangle = (baseLengthDouble * heightDouble) / 2;

//print the area of the triangle
Console.WriteLine("The area of the triangle is " + areaOfTriangle);

                                                                           