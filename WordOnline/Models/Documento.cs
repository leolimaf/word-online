using System.ComponentModel.DataAnnotations;

namespace WordOnline.Models;

public class Documento
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "O título é obrigatório!")]
    public string Titulo { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "O conteúdo é obrigatório!")]
    public string Conteudo { get; set; } = string.Empty;
    
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    
    public DateTime DataAlteracao { get; set; } = DateTime.Now;
}