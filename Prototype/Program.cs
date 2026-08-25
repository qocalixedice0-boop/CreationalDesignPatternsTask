

using Prototype;

User user1 = new User();
user1.Name = "Ashraf";
user1.Age = 21;
user1.Role = "Admin";

User user2 = user1.Clone();


Console.WriteLine(user2.Name);
Console.WriteLine(user2.Age);
Console.WriteLine(user2.Role);

Console.WriteLine(user1 == user2);