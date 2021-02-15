using BusinessModels;
using IContracts;
using System;
using Factory;

namespace DesignPatterns
{
    class Program
    {
        private static IRoleBase admin = FactoryPool.Create("admin");
        static void Main(string[] args)
        {
            setAdmin();
            admin.Validate();
        }
        private static void setAdmin()
        {
            admin.FirstName = "firstName";
            admin.LastName = "lastName";
            admin.Email = "abc@gmail.com";
            admin.UserID = "abcd";
            admin.Address = "address";
            admin.SSN = "087-868-7998";
          
        }
    }
}
