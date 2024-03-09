using System.ComponentModel.DataAnnotations;

namespace Libreria.Models;

public class Sistemas
{
    public int SistemaId { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    public string? NombreSistema { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    public string? DescripcionSistema { get; set; }
}
