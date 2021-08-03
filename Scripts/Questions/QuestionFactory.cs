using System;
namespace SoftwareDesignQuiz
{
    public static class QuestionFactory
    {
        public static void Main(String[] args){
            QuestionFactory.createQuestion();
        }
        public static void createQuestion(){
            Console.WriteLine("Please choose the kind of question.");
            String type = Console.ReadLine();
            switch (type)
            {
                case "SpecificText":
                    SpecificText questionST = new SpecificText();
                    Console.WriteLine("Please provide the question");
                    questionST.questionTitle = Console.ReadLine();
                    questionST.createAnswers();
                    break;
                case "SpecificNumber":
                    SpecificNumber questionSN = new SpecificNumber();
                    Console.WriteLine("Please provide the question");
                    questionSN.questionTitle = Console.ReadLine();
                    questionSN.createAnswers();
                    break;
                case "MultipleChoice":
                    MultipleChoice questionMC = new MultipleChoice();
                    Console.WriteLine("Please provide the question");
                    questionMC.questionTitle = Console.ReadLine();
                    questionMC.createAnswers();
                    break;
                default:
                
                    break;
            }
            
            
        }
        
    }
}