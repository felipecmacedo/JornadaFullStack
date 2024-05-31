using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;
public class DeleteCategoryRequest : Request
{
    [Required(ErrorMessage = "Identificador inválido")]
    public long Id { get; set; }
}
