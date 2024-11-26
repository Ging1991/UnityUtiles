using System.Collections.Generic;

namespace Ging1991.Persistencia {
		
	public class LectorListaCadena : LectorGenerico<LectorListaCadena.Dato> {

		public LectorListaCadena(Direccion direccion) : base(direccion) {}


		public  void Guardar(List<string> valor) {
			Dato dato= new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public List<string> valor;

		}

	}

}