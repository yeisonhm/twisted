using System;
using Iesi.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcApplication1.Dominio.Model
{
    public class ViajeXml
    {

        public string Destino { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Hospedaje { get; set; }
        public int IdViaje { get; set; }
        public string Nombre { get; set; }
        public string Privacidad { get; set; }
        public DestinoXml[] Destinos { get; set; }
    }
}
