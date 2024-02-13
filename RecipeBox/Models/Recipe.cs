using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    [Required(ErrorMessage = "The recipe must have a name!")]
    public string RecipeName { get; set; }
    [Required(ErrorMessage = "The recipe must have ingredients!")]
    public string Ingredients { get; set; }
    [Required(ErrorMessage = "The recipe must have instructions!")]
    public string Instructions { get; set; }
    [Range(1, 10, ErrorMessage = "The recipe must have a rating from 1-10")]
    public int Rating { get; set; }
    public List<RecipeTag> JoinEntities { get; }

    public ApplicationUser User { get; set; }
  }
}