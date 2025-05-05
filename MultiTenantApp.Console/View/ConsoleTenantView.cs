using System;
using System.Collections.Generic;
using MultiTenantApp.Console.Model;

namespace MultiTenantApp.Console.View
{
    public class ConsoleTenantView : ITenantView
    {
        public string GetTenantId()
        {
            System.Console.Write("Enter tenant ID: ");
            return System.Console.ReadLine() ?? string.Empty;
        }

        public void DisplayData(IEnumerable<TenantData> data)
        {
            System.Console.WriteLine("\nTenant Data:");
            System.Console.WriteLine("------------");
            
            foreach (var item in data)
            {
                System.Console.WriteLine($"ID: {item.Id}");
                System.Console.WriteLine($"Title: {item.Title}");
                System.Console.WriteLine($"Body: {item.Body}");
                System.Console.WriteLine($"User ID: {item.UserId}");
                System.Console.WriteLine("------------");
            }
        }

        public void DisplayError(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Error: {message}");
            System.Console.ResetColor();
        }
    }
} 