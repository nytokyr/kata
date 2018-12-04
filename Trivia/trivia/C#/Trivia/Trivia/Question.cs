using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    public class Question
    {
        public string Category { get; private set; }
        public string Interrogation { get; private set; }

        public Question(string category,string interrogation)
        {
            this.Category = category;
            this.Interrogation = interrogation;
        }
    }
}
