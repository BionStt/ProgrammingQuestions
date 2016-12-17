using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using ProgrammingQuestions.Drivers;

namespace ProgrammingQuestions.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult RandomQuestion(string subject = "")
        {
            ProgrammingQuestionCollection questions = XmlWorker.GetQuestions(_env);
            ViewBag.Subjects = questions.Questions
                .Select(q => new { Value = q.Subject, Text = q.Subject })
                .Distinct()
                .OrderBy(q => q.Text);

            if (subject != "")
            {
                return View(questions.GetRandomQuestion(subject));
            }

            return View(questions.GetRandomQuestion());
        }
    }
}