using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsRegisterInterface
{
    public class User
    {
        public User(dynamic data)
        {
            this.id = data.id;
            this.name = data.name;
            this.email = data.email;
            this.code = data.code;
            this.phoneNumber = data.phoneNumber;
            this.status = data.status == "true" ? true : false;
            this.userType = new UserType(data.userType);
        }
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string code { get; set; }
        public string phoneNumber { get; set; }
        public bool status { get; set; }
        public UserType userType { get; set; }
    }
    
    public class UserType
    {
        public UserType(dynamic data)
        {
            id = data.id;
            description = data.description;
        }
        public int id { get; set; }
        public string description { get; set; }
    }
}

/*
    "id": "17452ea3-38d6-4f5f-a534-6215e3ecb43b",      
    "name": "Alexis Gutierrez",      
    "email": "alexis@mail.com",    
    "code": "211664946",      
    "phoneNumber": "",      
    status": true    },   
 * */
