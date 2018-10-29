﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MumanalPG.Models.Ventas
{
	[Table("VentaTarifario", Schema = "Ventas")]
	public class VentaTarifario
	{
		[DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		[Key]
		public Int32 IdVentaTarifario { get; set; }
		public string Descripcion { get; set; }
		public Int32 IdProcesoNivel2 { get; set; }
		public Int32 IdBeneficiarioCategoria { get; set; }
		public Int32 NumeroCuotas { get; set; }
		public Int32 NuemroPeriodos { get; set; }
		public Decimal ValorInicialBs { get; set; }
		public Decimal InteresBs { get; set; }
		public Decimal ValorFinalBs { get; set; }
		public Decimal Porcentaje { get; set; }
		public Int32 IdEstadoRegistro { get; set; }
		public Int32 IdUsuario { get; set; }
		public DateTime FechaRegistro { get; set; }
	}
}


