using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RecipeBox.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class SearchController : Controller
{
  private readonly RecipeBoxContext _db;

  public SearchController(RecipeBoxContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    return View();
  }

  [HttpPost]
  public async Task<IActionResult> Results(string query, string searchType)
  {
    if (searchType == "Recipe")
    {
      var recipes = await SearchRecipes(query);
      return View("Results", recipes);
    }
    else if (searchType == "Tag")
    {
      var tags = await SearchTags(query);
      return View("Results", tags);
    }

    return View("Results");
  }

  private async Task<List<Recipe>> SearchRecipes(string query)
  {
    IQueryable<Recipe> result = _db.Set<Recipe>();

    if (query != null)
    {
      return await result?.Where(recipe => recipe.RecipeName.Contains(query) || recipe.Instructions.Contains(query) || recipe.Ingredients.Contains(query)).ToListAsync();
    }
    else
    {
      return await result.ToListAsync();
    }
  }

  private async Task<List<Tag>> SearchTags(string query)
  {
    IQueryable<Tag> result = _db.Set<Tag>();

    if (query != null)
    {
      return await result?.Where(tag => tag.TagName.Contains(query)).ToListAsync();
    }
    else
    {
      return await result.ToListAsync();
     }
  }
}