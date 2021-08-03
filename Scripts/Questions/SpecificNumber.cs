using System;

namespace SoftwareDesignQuiz
{
    public class SpecificNumber : iQuestion
    {
        public string questionTitle {get;set;}
        Answer answer;
        public SpecificNumber(String title){
            this.questionTitle = title;
        }
        public SpecificNumber(){
        }
        public void createAnswers(){
            Console.WriteLine("Please give the correct answer for your given quesion");
            String answerText = Console.ReadLine();
            answer = new Answer(answerText, true);
        }
        public void play(){
            
        }
    }
}