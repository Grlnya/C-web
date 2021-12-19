using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Userr
    {
        public string login;
        public string password;
        public string FullName;
        public string birthdate;

        public Userr() { }
        public Userr( string login, string password, string FullName, string birthdate) 
            {
            this.login = login;
            this.password = password;
            this.FullName = FullName;
            this.birthdate = birthdate;
            }
        
    }


}
