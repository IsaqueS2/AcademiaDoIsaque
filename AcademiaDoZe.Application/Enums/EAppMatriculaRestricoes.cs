//ISAQUE DE OLIVEIRA DOS SANTOS
using System.ComponentModel.DataAnnotations;
namespace AcademiaDoZe.Application.Enums
{
    [Flags]
    public enum EAppMatriculaRestricoes
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
}