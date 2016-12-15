using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProgrammingQuestions.Drivers
{
    public class ProgrammingQuestionCollection
    {
        public ProgrammingQuestion[] Questions { get; set; }

        public ProgrammingQuestionCollection()
        {

        }

        public ProgrammingQuestion GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(0, Questions.Length - 1);

            return Questions[index];
        }

        public ProgrammingQuestion GetRandomQuestion(string subject)
        {
            var questionsFromSubject = Questions.Where(q => q.Subject == subject).ToList();
            Random random = new Random();
            int index = random.Next(0, questionsFromSubject.Count);

            return questionsFromSubject[index];
        }
    }
}
