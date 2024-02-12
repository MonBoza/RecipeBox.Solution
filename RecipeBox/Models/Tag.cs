using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Tag
  {
    public int TagId { get; set; }

    [Required(ErrorMessage ="Please enter a tag name")]
    public string TagName {get; set;}
    public List<RecipeTag> JoinEntities { get; }
  }
}