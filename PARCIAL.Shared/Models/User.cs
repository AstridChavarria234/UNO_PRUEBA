using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL.Data.Entities
{
    public class User
    {
        public string Name { get; set; }

        public string Group { get; set; }


        public string Id { get; set; }

        public string userName { get; set; }


        public string normalizedUserName { get; set; }

        public string Email { get; set; }



        public string emailConfirmed { get; set; }


        public string passwordHash { get; set; }

        public string securityStamp { get; set; }


        public string concurrencyStamp { get; set; }

        public string phoneNumber { get; set; }

        public string phoneNumberConfirmed { get; set; }


        public string twoFactorEnabled { get; set; }

        public string lockoutEnd { get; set; }


        public string lockoutEnabled { get; set; }

        public string accessFailedCount { get; set; }





    }
}
