
using Microsoft.AspNetCore.Mvc;
using My_Second_MVC_app.Models;

namespace My_Second_MVC_app.Controllers;

public class HelloController : Controller
{

    [HttpGet]
    public IActionResult Index(string name= "World")
    {
        string html = "<form method = 'post'>" + 
        "<input type = 'text' name = 'name' />" + 
        "<select name = 'language'>" +
        "<option value = 'english' selected= 'selected'>English</option>" +
        "<option value = 'french'>French</option>" +
        "<option value = 'spainish'>Spainish</option>" +
        "<option value = 'japanese'>Japanese</option>" +
        "<option value = 'chinese'>Chinese</option>" +
        "<option value = 'german'>German</option>" +
        "</select>" +
        "<input type = 'submit' value = 'Greet Me!' />" + 
        "</form>";
        return Content(html, "text/html");
    }
    [Route("/Hello")]
    [HttpPost]
    public IActionResult CreateMessage(string name= "World", string language = "")
    {
        if (language == "english")
        {
            language = "Hello";
        }
        if (language == "french")
        {
            language = "Bonjour";
        }
        if (language == "spainish")
        {
            language = "Hola";
        }
        if (language == "japanese")
        {
            language = "Kon'nichiwa";
        }
        if (language == "chinese")
        {
            language = "Ni Hao";
        }
        if(language == "german")
        {
            language = "Hallo";
        }
        return Content(string.Format("<h1>{1}, {0}</h1>", name, language), "text/html");
    }
    [Route("/Hello/{name}")]
    public IActionResult Index2(string name= "World")
    {
        return Content(string.Format("<h1>Hello, {0}</h1>", name), "text/html");
    }
    public IActionResult Goodbye()
    {
        return Content("Goodbye");
    }

}
