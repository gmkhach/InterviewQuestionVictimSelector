using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionSelectorDomain.Entities
{
    class Question
    {
        public Question(string text, int questionID)
        {
            Text = text;
            QuestionID = questionID;
        }

        public string Text { get; set; }
        public int QuestionID { get; set; }
    }
}
