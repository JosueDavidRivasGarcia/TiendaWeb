using System.ComponentModel.DataAnnotations;

namespace TiendaWeb.Models;
public class Categorias
{
    [Key]
    public int id { get; set; }
    [Display(Name ="Nombre Categoria")]
    [Required(ErrorMessage ="Ingresa el Nombre de la Categoria")]
    public string nombre { get; set; }
}