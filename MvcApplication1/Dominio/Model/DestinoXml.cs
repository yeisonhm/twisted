using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Iesi.Collections.Generic;

namespace MvcApplication1.Dominio.Model
{
	
	public class DestinoXml
	{
        public string Descripcion { get; set; }
		public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
		public int IdDestino { get; set; }
		public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Nombre { get; set; }
		public string UrlFoto { get; set; }
    }
}