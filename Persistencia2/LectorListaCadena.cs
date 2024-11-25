using System.Collections.Generic;

namespace Caballero.Persistencia {
		
	public class LectorListaCadena : LectorGenerico<LectorListaCadena.Dato> {

		public LectorListaCadena(string carpeta, string archivo) : base(carpeta, archivo) {}


		public Dato LeerDatos() {
			Dato dato = Leer();
			if (dato == null) {
				dato = new Dato(new List<string>());
			}
			if (dato.valor == null) {
				dato.valor = new List<string>();
			}
			return dato;
		}


		public void GuardarDatos(Dato dato) {
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public Dato(List<string> valor) {
				this.valor = valor;
			}

			public List<string> valor;

		}

	}

}