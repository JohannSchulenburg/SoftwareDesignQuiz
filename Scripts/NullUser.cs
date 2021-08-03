using System;

namespace SoftwareDesignQuiz
{
    public class NullUser
    {
        int id;

        Statistic statistic;
        public virtual void signUp(string name, string password){
            User user = new User(name, password);
        }
        public void signIn(string name, string password){
            
        }
        public void play(int gameId){

        }
        public Statistic showStats(){
            return statistic;
        }
    }
}