// There are watchtowers in the region around Consolas that can alert
// you when an enemy is spotted. With some help from you, they can tell
// you which direction the enemy is from the watchtower.
// • Ask the user for an x value and a y value. These are coordinates of
// the enemy relative to the watchtower’s location.
// • Using the image on the right, if statements, and relational
// operators, display a message about what direction the enemy is
// coming from. For example, “The enemy is to the northwest!” or "The enemy is here!"

Console.WriteLine("Enter the x coordinate of the enemy:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the y coordinate of the enemy:");
int y = int.Parse(Console.ReadLine());

string direction;

if (x == 0 && y == 0)
{
    direction = "here!";
}
else if (x == 0)
{
    direction = y > 0 ? "to the north!" : "to the south!";
}
else if (y == 0)
{
    direction = x > 0 ? "to the east!" : "to the west!";
}
else
{
    if (x > 0 && y > 0)
        direction = "to the northeast!";
    else if (x > 0 && y < 0)
        direction = "to the southeast!";
    else if (x < 0 && y > 0)
        direction = "to the northwest!";
    else
        direction = "to the southwest!";
}

Console.WriteLine($"The enemy is {direction}");
