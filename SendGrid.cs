using SendGrid;
using SendGrid.Helpers.Mail;
using System.Configuration;

namespace parkDB
{


    // CLASE PARA EL MANEJO DE SENDGRID API
    // UTILIZADA PARA ENVIAR CORREOS DE RECUPERACION DE CONTRASEÑA
    // EL METODO EnviarRecuperacionAsync() RETORNA UN BOOLEANO SEGÚN LA RESPUESTA SMTP


    class SendGrid
    {
        private string APIKey = ConfigurationManager.AppSettings["SendGridAPIKey"];

        public SendGrid() { }
        public bool EnviarRecuperacionAsync(string email, string codigo)
        {
            var cliente = new SendGridClient(APIKey);
            var remitente = new EmailAddress("noreply@park.com", "PARK - Soporte Técnico");
            string asunto = "Recuperación de Contraseña";
            var destinatario = new EmailAddress(email);
            string contenidoPlano = $"{codigo}";
            string contenidoHTML = generarContenidoHTML(codigo);
            var msg = MailHelper.CreateSingleEmail(remitente, destinatario, asunto, contenidoPlano, contenidoHTML);
            var respuesta = cliente.SendEmailAsync(msg);
            return true;
        }
        private string generarContenidoHTML(string codigo) // GENERA UNA PLANTILLA HTML PARA EL CUERPO DEL CORREO
        {
            string imagenHeader = "<img src=\"https://i.ibb.co/gy8yJT8/email-Header.png \"/>\n";
            string codigoRecuperacion = $"<h1 style=\"font-family: Arial, Helvetica, sans-serif; font-size: 30px; padding-left: 200px\">{codigo}</h1>";

            return imagenHeader + codigoRecuperacion;
        }
    }
}
