using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace UserRegistrationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {           

        // User registration service- obtains user name and password and stores in database (JSON)
        public Boolean registerUser(string username, string password)
        {
            // Flag variable to check if the user is already registered
            Boolean user_already_exists = false;

            //Flag variable to return resgitration status to user
            Boolean feedback = false;

            // Password stored as bytes in encrypted format
            byte[] password_bytes;

            // encrypted password in string format
            string password_encrypted_secure = "";

            //list of users in json format
            string json;

            //Object to store user credentials
            UserCredential newregistration = new UserCredential();
            UserObject userobject = new UserObject();

            //list of users
            List<UserCredential> list_of_users = new List<UserCredential>();

            //path in server to store database.json           
            string path = HttpRuntime.AppDomainAppPath + "\\database.json";

            try
            {
                //Reads content in json file as a string
                string jsonData = File.ReadAllText(path);

                //Deserialize json to c# object
                userobject = JsonConvert.DeserializeObject<UserObject>(jsonData);


                if (userobject.users != null)
                {
                    // list of users
                    list_of_users = userobject.users.ToList<UserCredential>();

                    foreach (UserCredential user in list_of_users)
                    {
                        //Check if user is already registered
                        if (user.username == username)
                        {
                            user_already_exists = true;
                        }
                    }
                }

                if (!user_already_exists)
                {
                    //Password is encrypted
                    password_bytes = Encoding.ASCII.GetBytes(password);


                    foreach (byte digit in password_bytes)
                    {
                        password_encrypted_secure += digit;
                    }

                    //Get-Set user credentials
                    newregistration.username = username;
                    newregistration.password = password_encrypted_secure;
                    list_of_users.Add(newregistration);

                    //Convert list of users to object
                    userobject.users = list_of_users.ToArray<UserCredential>();

                    //Serialize object to JSON
                    json = JsonConvert.SerializeObject(userobject, Formatting.Indented);

                    File.WriteAllText(path, json);

                    //Set flag to true
                    feedback = true;
                }
            }
            finally
            {

            }

            //Returns success or failure whether user registration has occured succesfully
            return feedback;

        }

        //Getter-Setter for user credential
        public class UserCredential
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        //User object creation
        public class UserObject
        {
            public UserCredential[] users { get; set; }
        }



    }
}


