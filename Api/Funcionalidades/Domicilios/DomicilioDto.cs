namespace Api.Funcionalidades.Domicilios
{
    public class DomicilioDto
    {
        public required string Calle {get; set; }
        public required int Altura {get; set; }
        public required int CodigoPostal {get; set; }
    }
}