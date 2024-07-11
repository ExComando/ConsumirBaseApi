namespace App_Empresa.Components.Data;
using System.Text.Json.Serialization;
public class Cliente
    {
        [JsonPropertyName("id_Cliente")]
        public int? Id_cliente { get; set; }

        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }

        [JsonPropertyName("apellido")]
        public string? Apellido { get; set; }

        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }

        [JsonPropertyName("telefono")]
        public string? Telefono { get; set; }

        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? Fecha_nacimiento { get; set; }
    }