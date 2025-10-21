using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

public class Consumo
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos numéricos.")]
    public string Cpf { get; set; } = string.Empty; // manter como string

    [Range(1, 12)]
    public int Mes { get; set; }

    [Range(1900, 2100)]
    public int Ano { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal M3Consumidos { get; set; }  // precisão melhor que double

    [Required]
    public string Bandeira { get; set; } = string.Empty; // ou use enum

    public bool PossuiEsgoto { get; set; }
}