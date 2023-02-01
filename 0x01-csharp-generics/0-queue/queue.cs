using System;
/// <summary>
/// Customized Queue class
/// </summary>
/// <typeparam name="T">The elements type</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Method that returns the type of the Queue's elements
    /// </summary>
    /// <returns>The type of the Queue's elements</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}