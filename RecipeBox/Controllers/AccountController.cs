using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
// using RecipeBox.ViewModels;

namespace RecipeBox.Controllers
{
  public class AccountController : Controller
  {
    private readonly RecipeBoxContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RecipeBoxContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }
    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }
  }
}