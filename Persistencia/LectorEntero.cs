namespace Ging1991.Persistencia {
		
	public class LectorEntero : LectorGenerico<LectorEntero.Dato> {

		public LectorEntero(Direccion direccion) : base(direccion) {}


		public void Guardar(int valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public int valor;

		}


	}

}