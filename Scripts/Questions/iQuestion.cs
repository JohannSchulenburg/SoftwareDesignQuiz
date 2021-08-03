namespace SoftwareDesignQuiz
{
    public interface iQuestion
    {
        public string questionTitle {get;set;}
        public void createAnswers(); 
        public void play();
    }
}