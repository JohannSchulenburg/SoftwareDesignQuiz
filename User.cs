using System;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace SoftwareDesignQuiz
{
    public class User : NullUser
    {
        string name;
        string password;
        public User(string name, string password){
            this.name = name;
            this.password = password;
        }

        public override void signUp(string name, string password)
        {
            Console.WriteLine("You are already signed up, dummy!");
        }
    }
}