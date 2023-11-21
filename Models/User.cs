using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WemaBITCsharp.Models
{
    public class Users
    {
        private int id;
        private List<Users> userList = new List<Users>();
        public int Id { get { return id;  } set { id = new GenerateId().Generate(); } }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Users> UserList { 
            get { return this.userList; }
        }

        public Users CreateUser()
        {
            Users newUser = new Users { Id = Id, FirstName = FirstName, LastName = LastName };
            UserList.Add( newUser );
            return newUser;
        }

        public List<Users> GetUsers()
        {
            return UserList;
        }

       
    }


    public class GenerateId
    {

            public long MinVal = 10000;
            public long MaxVal = 9999999;

            public int Generate()
            {
                Random random = new Random();

                // Generate a random integer
                int randomNumber = random.Next((int)MinVal, (int)MaxVal + 1);
                return randomNumber;
            }

    }


}
