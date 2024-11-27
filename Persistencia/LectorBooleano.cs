namespace Ging1991.Persistencia {
		
	public class LectorBooleano : LectorGenerico<LectorBooleano.Dato> {

		public LectorBooleano(string direccion, string direccionInicializacion = "") : base(direccion, direccionInicializacion) {}


		public void Guardar(bool valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public bool valor;

		}


	}

}