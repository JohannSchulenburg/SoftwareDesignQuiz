using System;
namespace SoftwareDesignQuiz
{
    public class SpecificText : iQuestion
    {
        public string questionTitle {get;set;}
        Answer answer;
        public SpecificText(String title){
            this.questionTitle = title;
        }
        public SpecificText(){
        }
        public void createAnswers(){
            Console.WriteLine("Please give the correct answer for your given quesion");
            String answerText = Console.ReadLine();
            answer = new Answer(answerText, true);
        }
        public void play(){
            Console.WriteLine(questionTitle);
            string givenAnswer = Console.ReadLine();
            if(givenAnswer.Equals(this.answer.answerText)){
                Console.Write("Correct!");
            }
            else{
                Console.Write("Wrong");
            }
        }
    }
}