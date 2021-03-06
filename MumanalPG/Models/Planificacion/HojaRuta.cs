﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumanalPG.Models.Planificacion
{
	[Table("HojaRuta", Schema = "Planificacion")]
	public class HojaRuta
	{
		[DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		[Key]
		public Int32 IdHojaRuta { get; set; }
        public Int32 IdUnidadEjecutora { get; set; }
        public Int32 SolicitudCodigo { get; set; }
        //public Int32 IdUnidadNivel3 { get; set; }
		public string CiteTramite { get; set; }
		public DateTime CiteFecha { get; set; }
		public Int32 NroFojas { get; set; }
		public Int32 IdEstadoRegistro { get; set; }
		public Int32 IdUsuario { get; set; }
		public DateTime FechaRegistro { get; set; }
		public string HoraRegistro { get; set; }
	}
}