using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
   public class User :RoleBase
    {
        public override void Validate()
        {
            if (string.IsNullOrEmpty(SSN))
            {
                throw new Exception("SSN is required");
            }
        }
    }
}
