using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bootstrap.WebUI.Models;

namespace Bootstrap.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Gallery()
    {
        var images = new List<ImageModel>();
        images.Add(new ImageModel { LowRes = "/images/251-600x600.jpg", HighRes = "/images/251-1200x768.jpg"});
        // images.Add("/images/251-600x600.jpg");
        // images.Add("/images/252-600x600.jpg");
        // images.Add("/images/253-600x600.jpg");
        // images.Add("/images/254-600x600.jpg");
        // images.Add("/images/255-600x600.jpg");
        // images.Add("/images/256-600x600.jpg");
        return View(images);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
