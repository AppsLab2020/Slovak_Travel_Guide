
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.Table
{
    class RegUserTable
    {
        [PrimaryKey, AutoIncrement]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        [MaxLength(12)]
        public string Password { get; set; }
        [MaxLength (16)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public RegUserTable()
        {
            
        }
    }
}
