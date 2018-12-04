using System.Collections.Generic;

namespace Trivia
{
    public class QuestionManager : IQuestionManager
    {
        Dictionary<string, Queue<string>> _QuestionsCategories = new Dictionary<string, Queue<string>>();

        public QuestionManager()
        {
            _QuestionsCategories["Pop"] = new Queue<string>();
            _QuestionsCategories["Science"] = new Queue<string>();
            _QuestionsCategories["Sports"] = new Queue<string>();
            _QuestionsCategories["Rock"] = new Queue<string>();

            this.GenerateQuestions();
        }
        public void GenerateQuestions()
        {
            for (int i = 0; i < 50; i++)
            {
                _QuestionsCategories["Pop"].Enqueue("Pop Question " + i);
                _QuestionsCategories["Science"].Enqueue("Science Question " + i);
                _QuestionsCategories["Sports"].Enqueue("Sports Question " + i);
                _QuestionsCategories["Rock"].Enqueue("Rock Question " + i);
            }
        }
        public Question AskQuestion(int playerPosition)
        {
            string currentCategory = GetCurrentCategory(playerPosition);
            string question = _QuestionsCategories[currentCategory].Dequeue();

            return new Question(currentCategory, question);

        }
        private string GetCurrentCategory(int playerPosition)
        {
            if (playerPosition % 4 == 0)
                return "Pop";
            if (playerPosition % 4 == 1)
                return "Science";
            if (playerPosition % 4 == 2)
                return "Sports";

            return "Rock";
        }
    }
}
