using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Model;
using System.Text.RegularExpressions;
using System;

namespace ScrabbleScore.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); } 
  
    [Route("/scrabblescore")]
    public ActionResult ScrabbleScore (string input)
    {
      Score GitItSon = new Score();
      GitItSon.GitItMaam = GitItSon.CheckScore(input);
      return View(GitItSon);
    }
  }
}