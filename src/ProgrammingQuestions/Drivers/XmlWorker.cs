using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProgrammingQuestions.Drivers
{
    public class XmlWorker
    {
        public static ProgrammingQuestionCollection GetQuestions(Microsoft.AspNetCore.Hosting.IHostingEnvironment _env)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ProgrammingQuestionCollection));
            FileStream myFileStream = new FileStream(_env.ContentRootPath + "\\QuestionBank\\ProgrammingQuestions.xml", FileMode.Open);
            ProgrammingQuestionCollection pqc = ((ProgrammingQuestionCollection)ser.Deserialize(myFileStream));
            myFileStream.Dispose();

            return pqc;
        }
    }
}
