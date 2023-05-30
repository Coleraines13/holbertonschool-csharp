using System;

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
    /// <returns> formated string </returns>
    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}