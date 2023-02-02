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
public abstract class Base
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
/// TestObject: class that inherits from the "Base" class and the previous 3 interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// durability: property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// isCollected: property
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// implement this method from the interface
    /// </summary>
    public void Interact()
    { 
    }
  

    /// <summary>
    /// implement this method from the interface
    /// </summary>
    public void Break()
    { 
    }
    

    /// <summary>
    /// implement this method from the interface
    /// </summary>
    public void Collect()
    { 
    }
}