



Console.WriteLine(" Hello! Today we will be calculating the area, perimeter, surface area, and volume of a room!");
Console.WriteLine(" First things first, what is the length of the given room in feet?");


// recieving answers
float length = float.Parse(Console.ReadLine());
Console.WriteLine(" Now for the width of the room. What is the width in feet?");
float width = float.Parse(Console.ReadLine());
Console.WriteLine("Now for the height, How tall is the room in feet?");
float height = float.Parse(Console.ReadLine());



// Math section 
float perimeter = width + width + length + length;
float area = width * length;
float surfaceArea = 2 * ((length * width) + (length * height) + (width * height));
float volume = length * width * height;
string roomSize;

if (area <= 250)
    roomSize = "The room size is classified is small";
else if (area < 650)
    roomSize = " The room size is classified as medium";
else
    roomSize = " The room size is classified as big";
    

Console.WriteLine("The Perimeter of your room is " + perimeter);
Console.WriteLine("The area of your room is " + area);
Console.WriteLine("The surface area of your room is " + surfaceArea);
Console.WriteLine("The volume of your room is " + volume);
Console.WriteLine(roomSize);


