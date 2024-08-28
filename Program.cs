using System;
using System.IO;


class Program
{
    static void Main()
    {
        Logger logger = new("application.log");

        logger.Log("User logged in", "INFO");
        logger.Log("Failed login attempt", "WARNING");
    }
}