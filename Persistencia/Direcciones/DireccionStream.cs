namespace Ging1991.Persistencia.Direcciones {

	public class DireccionStream : Direccion {

		private readonly string CARPETA_BASE = "\\TEMPORAL\\";

		public DireccionStream(string carpeta, string archivo = "") : base(carpeta, archivo) {
			CrearCarpetaSiNoExiste(Generar(""));
		}


		public override string Generar() {
			return $"{GetDireccionPlataforma()}{CARPETA_BASE}\\{carpeta}\\{archivo}";
		}


		public override string Generar(string archivo) {
			return $"{GetDireccionPlataforma()}{CARPETA_BASE}\\{carpeta}\\{archivo}";
		}


	}

}