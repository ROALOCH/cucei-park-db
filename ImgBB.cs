using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace parkDB
{


    // CLASE PARA EL MANEJO DE IMGBB API
    // UTILIZADA PARA SUBIR IMAGENES A LA NUBE
    // EL METODO SubirImagen() RETORNA LA URL DONDE SE ALMACENA EL ARCHIVO


    class ImgBB
    {
        private string urlCloud = "";
        private static readonly HttpClient cliente = new HttpClient();
        private string APIUri = ConfigurationManager.AppSettings["ImgbbAPIUri"];
        private string APIKey = ConfigurationManager.AppSettings["ImgbbAPIKey"];

        public ImgBB() { }
        public async Task<string> SubirImagenAsync(string pathArchivo)
        {
            string base64 = convertirBase64(pathArchivo);
            var respuesta = await subirImagenAPI(base64);

            return urlCloud;
        }
        private string convertirBase64(string pathArchivo) // CONVIERTE LA IMAGEN A BASE64
        {
            using (System.Drawing.Image imagen = System.Drawing.Image.FromFile(pathArchivo))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    imagen.Save(m, imagen.RawFormat);
                    byte[] imagenBytes = m.ToArray();
                    return Convert.ToBase64String(imagenBytes);
                }
            }
        }
        private async Task<HttpResponseMessage> subirImagenAPI(string base64)
        {
            var parametros = new Dictionary<string, string>
            {
                {"key", APIKey },
                {"image", base64 }
            };

            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var contenido = new FormUrlEncodedContent(parametros);
            var respuesta = await cliente.PostAsync(APIUri, contenido);
            var respuestaString = await respuesta.Content.ReadAsStringAsync();

            // PARSEAR RESPUESTA A OBJETO JSON //

            JObject joRespuesta = JObject.Parse(respuestaString);
            JObject joDatos = (JObject)joRespuesta["data"];
            urlCloud = joDatos["display_url"].ToString();

            return respuesta;
        }
    }
}
