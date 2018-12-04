using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
   public interface IQuestionManager
    {
        Question AskQuestion(int playerPosition);
    }
}
