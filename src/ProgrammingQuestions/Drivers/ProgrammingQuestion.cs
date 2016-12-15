using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingQuestions.Drivers
{
    public class ProgrammingQuestion
    {
        public int Difficulty { get; set; }
        public string Question { get; set; }
        public string Subject { get; set; }
        public string Source { get; set; }

        public ProgrammingQuestion() { }
    }
}