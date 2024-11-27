using System.Collections.Generic;

namespace Ging1991.Persistencia {
		
	public class LectorListaEnteros : LectorGenerico<LectorListaEnteros.Dato> {
		
		public LectorListaEnteros(string direccion, string direccionInicializacion = "") : base(direccion, direccionInicializacion) {}
		
		
		public  void Guardar(List<int> valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public List<int> valor;

		}


	}

}