//declaring an array  variable of ints/strings/bools
int[] scores;
string[] names;
bool[] flags;

//constructing a new array to hold our items
scores = new int[5]; //we can make an array any size we want, but once it is constructed it can no longer change size
//however, we can use the new keyword a second time to create a second array with more (or fewer items)
//we can update scores with this new, longer array
scores = new int[20]; //this is a new array using new memory for its contents
// array length
Console.WriteLine(scores.Length);
//ask the user for a length, creates an array of that size, then uses a for loop to fill it with values
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = 1;
}

int lastScore = array[^1];

int[] firstThreeScores = scores[0..3]; //this will create a new array with the first three scores

// These numbers can be any int expression, and you can also use ^ to index from the back. For
// example, this code makes a copy of the array except for the first and last items:
int[] theMiddle = scores[1..^1];

// You can also leave off either end (or both ends) to use a default of the array’s start or end. For
// example, scores[2..] creates a copy of the entire array except the first two.
int [] theRest = scores[2..];

int[] otherScores = new int[] { 1, 2, 3, 4, 5 }; //collection initializer syntax

//if you know how many items you want to add, you don't need to specify the size of the array
int[] moreScores = new int[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

//if the type of the array is clear from the context, you can omit the type
int[] evenMoreScores = new [] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

//smallest number in an array
int[] arrayA = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = array[0];
Console.WriteLine(currentSmallest);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < currentSmallest)
    {
        currentSmallest  = array[i];
    }
}
Console.WriteLine(currentSmallest);

//average of an array
int[] arrayToAverage = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
for (int index = 0; index < array.Length; index++)
total += array[index];
float average = (float)total / array.Length;
Console.WriteLine(average);

// While searching an abandoned storage building containing strange code artifacts, you uncover the
// ancient Replicator of D’To. This can replicate the contents of any int array into another array. But it
// appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
// Objectives:
// • Make a program that creates an array of length 5.
// • Ask the user for five numbers and put them in the array.
// • Make a second array of length 5.
// • Use a loop to copy the values out of the original array and into the new one.
// • Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works again
int[] originalArray = new int[5];
int[] newArray = new int[5];
for (int i = 0; i < originalArray.Length; i++)
{
    Console.WriteLine("Enter a number:");
    originalArray[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = originalArray[i];
}
Console.WriteLine("Original Array:");
for (int i = 0; i < originalArray.Length; i++)
{
    Console.WriteLine(originalArray[i]);
}
Console.WriteLine("New Array:");
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}

int[][] matrix = new int[3][];
matrix[0] = new int[] { 1, 2 };
matrix[1] = new int[] { 3, 4 };
matrix[2] = new int[] { 5, 6 };
Console.WriteLine(matrix[0][1]); // Should be 2.

int[,] matrixB = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
Console.WriteLine(matrixB[0, 1]);

int[,] matrixC = new int[4,4];
for (int row = 0; row < matrixC.GetLength(0); row++)
{
for (int column = 0; column < matrixC.GetLength(1); column++)
Console.Write(matrixC[row, column] + " ");
Console.WriteLine();
}