namespace Ging1991.Persistencia.Direcciones {

	public class DireccionRecursos : Direccion {

		public DireccionRecursos(string carpeta, string archivo = "") : base(carpeta, archivo) {}


		public override string Generar() {
			return $"\\{carpeta}\\{archivo}";
		}


		public override string Generar(string archivo) {
			return $"\\{carpeta}\\{archivo}";
		}


	}


}