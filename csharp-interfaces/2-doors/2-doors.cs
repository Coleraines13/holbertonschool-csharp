using System;
/// <summary>
/// IInteractive: Interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact(): method
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable: Interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability: property
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// Break(): method
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable: intefrace
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// isCollected: property
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect(): method
    /// </summary>
    void Collect();
}

/// <summary>
/// Base: Class
/// </summary>
public class Base
{
    /// <summary>
    /// name property: string
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Override string
    /// </summary>
    /// <returns>formated string</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

/// <summary>
/// Door: class that inherits from the "Base" class and the previous "Interactive" interfaces
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="doorName">Default name of the door</param>
    public Door(string doorName = "Door")
    {
        name = doorName;
    }
    
    
    /// <summary>
    /// Implement the method of the "Interact" interface
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}