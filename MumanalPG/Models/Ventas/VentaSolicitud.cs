﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumanalPG.Models.Ventas
{
	[Table("VentaSolicitud", Schema = "Ventas")]
	public class VentaSolicitud
    {
		[DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		[Key]
		public Int32 IdVentaSolicitud { get; set; } // correlativo general, nose usa para nada mas
		public string Gestion { get; set; }
		public Int32 IdUnidadEjecutora { get; set; } //resuelto
		public Int32 CorrelativoUnidad { get; set; } // correlativo de la unidad ejecutora
		public Int32 IdDepartamento { get; set; }
		public DateTime FechaSolicitud { get; set; } = DateTime.Now.Date;
        public DateTime FechaRecepcionSolicitud { get; set; } = DateTime.Now.Date;
        public Int32 IdBeneficiario { get; set; }
		public Int32 IdBeneficiarioResponsable { get; set; }
		public string Justificacion { get; set; }
		public string Observaciones { get; set; }
		public string CiteTramite { get; set; }
		public Int32 MesNumero { get; set; }
        public Int32 IdPoa { get; set; }
		public Int32 IdProceso { get; set; }
		public Int32 IdDocumentoRespaldo { get; set; }
		public Int32 NumeroDocumento { get; set; }
		public string PathArchivo { get; set; }
		public Boolean ArchivoCargado { get; set; }
		public Int32 IdEstadoRegistro { get; set; }
		public Int32 IdUsuario { get; set; }
		public Int32 IdUsuarioAprueba { get; set; }
		public DateTime FechaRegistro { get; set; }
		public DateTime FechaAprueba { get; set; }
	}
}
