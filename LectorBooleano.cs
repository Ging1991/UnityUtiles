using Ging1991.Persistencia;

namespace Caballero.Persistencia {
		
	public class LectorBooleano : LectorGenerico<LectorBooleano.DatoBooleano> {

		public LectorBooleano(Direccion direccion) : base(direccion) {}


		[System.Serializable]
		public class DatoBooleano {

			public bool valor;

		}


	}

}