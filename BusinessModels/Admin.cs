using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
   public class Admin: RoleBase
    {
        public override void Validate() {
            if(string.IsNullOrEmpty(Address))
            {
                throw new Exception("Address is required");
            }
            if (string.IsNullOrEmpty(SSN))
            {
                throw new Exception("SSN is required");
            }
        }
    }
}
