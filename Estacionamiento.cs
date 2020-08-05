namespace parkDB
{


    // CLASE PARA EL MODELADO DE ESTACIONAMIENTOS
    // UTILIZADA PARA ALMACENAR LA INFORMACION LOCALMENTE
    // Y REDUCIR EL NÚMERO DE PETICIONES A LA BASE DE DATOS


    public class Estacionamiento
    {
        public Estacionamiento() { }
        public string ID { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Telefono { get; set; } = "";
        public int LugaresTotales { get; set; } = 0;
        public int LugaresOcupados { get; set; } = 0;
        public double PrecioNormal { get; set; } = 0;
        public double PrecioPension { get; set; } = 0;
        public override string ToString()
        {
            return Nombre;
        }
    }
}
