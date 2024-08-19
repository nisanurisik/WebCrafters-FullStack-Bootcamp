using System.ComponentModel.DataAnnotations;

namespace Kurslarım.Models
{
  public class Product
  {
    [Display(Name = "Bootcamp Id")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Bootcamp adı zorunlu")]
    [Display(Name = "Bootcamp Adı")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Bootcamp açıklaması zorunlu")]
    [Display(Name = "Bootcamp Açıklaması")]
    [StringLength(125, ErrorMessage = "{0} açıklama {2} ve {1} arasındaki kadar harf içermelidir.", MinimumLength = 10)]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Bootcamp saati zorunlu")]
    [Range(15, 50)]
    [Display(Name = "Bootcamp Saati")]
    public decimal? Clock { get; set; }

    [Display(Name = "Bootcamp Resmi")]
    public string? Image { get; set; } = string.Empty;
    public bool isActive { get; set; }

    [Required(ErrorMessage = "Bootcamp kategorisi zorunlu")]
    [Display(Name = "Bootcamp Kategorisi")]
    public int CategoryId { get; set; }

  }
}