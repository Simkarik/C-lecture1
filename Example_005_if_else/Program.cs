Console.WriteLine("Enter Username");
string username = Console.ReadLine();
if (username.ToLower() == "mark")
{
    Console.WriteLine("Oh, hey Mark!");
}
else
{
    Console.WriteLine("Hello, " + username);
}