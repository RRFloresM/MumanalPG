﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumanalPG.Models.Planificacion
{
	[Table("UnidadNivel3", Schema = "Planificacion")]
	public class UnidadNivel3
	{
		[DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		[Key]
		public Int32 IdUnidadNivel3 { get; set; }
		public Int32 IdUnidadNivel2 { get; set; }
		public string Descripcion { get; set; }
		public string Sigla { get; set; }
		public Int32 IdDepartamento { get; set; }
		public string Gestion { get; set; }
		public string EstadoCodigo { get; set; }
		public string UsuarioCodigo { get; set; }
		public DateTime FechaRegistro { get; set; }
	}
}