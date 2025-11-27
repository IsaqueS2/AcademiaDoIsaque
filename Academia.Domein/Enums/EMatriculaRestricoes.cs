//ISAQUE DE OLIVEIRA DOS SANTOS
namespace AcademiaDoZe.Domain.Enums;
using System.ComponentModel.DataAnnotations;
[Flags]
public enum EMatriculaRestricoes
{
    [Display(Name = "Diabetes")]
    Diabetes = 1,
    [Display(Name = "Pressão Alta")]
    PressaoAlta = 2,
    [Display(Name = "Labirintite")]
    Labirintite = 4,
    [Display(Name = "Alergias")]
    Alergias = 8,
    [Display(Name = "Tuberculose")]
    Tuberculose = 16,
    [Display(Name = "Pneumonia")]
    Pneumonia = 32
}


