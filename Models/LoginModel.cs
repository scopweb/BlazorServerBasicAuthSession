using System.ComponentModel.DataAnnotations;

namespace Scp04.Models
{
   
    public class LoginModel
        {
            [Required(ErrorMessage = "El email es requerido")]
            [EmailAddress(ErrorMessage = "Formato de email inválido")]
            public string Email { get; set; } = "admin@ejemplo.com";

            [Required(ErrorMessage = "La contraseña es requerida")]
            [StringLength(100, ErrorMessage = "La contraseña debe tener al menos {2} caracteres", MinimumLength = 6)]
            public string Password { get; set; } = "123456";
        }

    }
