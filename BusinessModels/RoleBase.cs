using IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
   public class RoleBase: IRoleBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserID { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string SSN { get; set; }

        public  virtual void Validate() {
            if(string.IsNullOrEmpty(FirstName))
            {
                throw new Exception("FirstName is required");
            }
            if (string.IsNullOrEmpty(LastName))
            {
                throw new Exception("LastName is required");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("Email is required");
            }
            if (string.IsNullOrEmpty(UserID))
            {
                throw new Exception("UserID is required");
            }
        }
    }
}
