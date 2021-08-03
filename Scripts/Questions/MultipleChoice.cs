using System;
using System.Runtime.InteropServices;
namespace SoftwareDesignQuiz
{
    public class MultipleChoice : iQuestion
    {
        public string questionTitle {get; set;}
        Answer[] answers;
        string[] answerTexts;
        bool[] bools;
        public MultipleChoice(String title){
            this.questionTitle = title;
        }
        public MultipleChoice(){
        }
        public void createAnswers(){
            Console.Write("Number of Answers: ");
            string nr = Console.ReadLine();
            int nrInt = Convert.ToInt16(nr);
            answerTexts = new string[nrInt];
            bools = new bool[nrInt];
            answers = new Answer[nrInt];
            Console.WriteLine("Please provide four answers with their respective boolean value (no Caps)");
            for(int i = 0; i<nrInt ;i++){
                Console.Write("Answer "+(i+1)+": ");
                answerTexts[i] = Console.ReadLine();
                Console.Write("Boolean "+(i+1)+": ");
                if(Console.ReadLine().Equals("true")){
                    bools[i] = true;
                }
                else{
                    bools[i] = false;
                }
                answers[i] = new Answer(answerTexts[i], bools[i]);
            }
        }
        public void play(){
            
        }
    }
}