using System;

namespace MultiTenantApp.Console.Model
{
    public class TenantData
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }
        public int UserId { get; set; }
    }
} 