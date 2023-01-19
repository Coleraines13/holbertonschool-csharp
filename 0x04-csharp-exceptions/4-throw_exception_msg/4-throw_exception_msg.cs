using System;

class Except
{
    public static void ThrownMsg(string msg)
    {
        throw new Exception(msg);
    }
}