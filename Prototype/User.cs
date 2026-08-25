

namespace Prototype;

internal class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }

    public User Clone()
    {
        User user = new User();
        user.Name = Name;
        user.Age = Age; 
        user.Role = Role;
        return user;
    }
}
