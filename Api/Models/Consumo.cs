using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

public class Consumo
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos numéricos.")]
    public string Cpf { get; set; } = string.Empty;

    [Range(1, 12)]
    public int Mes { get; set; }

    public int Ano { get; set; }

    public decimal M3Consumidos { get; set; }  
    
    public string Bandeira { get; set; } = string.Empty; 

    public bool PossuiEsgoto { get; set; }
}