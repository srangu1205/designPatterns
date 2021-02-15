using System;
using System.Collections.Generic;
using System.Text;

namespace IContracts
{
    public interface IRoleBase
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string UserID { get; set; }
        string ContactNumber { get; set; }
        string Address { get; set; }
        string SSN { get; set; }
        void Validate();
    }
}
