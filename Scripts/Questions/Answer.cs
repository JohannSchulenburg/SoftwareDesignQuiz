namespace SoftwareDesignQuiz
{
    public class Answer
    {
        public bool isCorrect;
        public string answerText;

        public Answer(string answerText, bool isCorrect){
            this.isCorrect = isCorrect;
            this.answerText = answerText;
        }
    }
}