using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.Table
{
    class RegUserTable
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public RegUserTable()
        {
            
        }
    }
}
