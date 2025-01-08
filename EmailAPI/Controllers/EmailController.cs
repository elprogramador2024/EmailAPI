using EmailModel.Comunes;
using EmailModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmailAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        #region Metodos
        /// <summary>
        /// Realiza simulación de email.
        /// </summary>
        /// <param name="email">Información del email a enviar.</param>
        /// <returns>Mensaje de respuesta.</returns>
        /// <response code="200">Correo Enviado! (mensaje)</response>
        [HttpPost("enviar")]
        public async Task<IActionResult> Enviar([FromBody] EmailVM email)
        {
            Console.WriteLine($"Simulación Envío Correo");
            Console.WriteLine($"=======================");
            
            Console.WriteLine($"Email: {email.Email}");
            Console.WriteLine($"Parqueadero: {email.ParqueaderoNombre}");
            Console.WriteLine($"Placa: {email.Placa}");
            Console.WriteLine($"Mensaje: {email.Mensaje}");
            Console.WriteLine($"=======================");

            return Ok(new Msj() { Mensaje = "Correo Enviado!" });
        }
        #endregion
    }
}
