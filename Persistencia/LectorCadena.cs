namespace Ging1991.Persistencia {
		
	public class LectorCadena : LectorGenerico<LectorCadena.Dato> {


		public LectorCadena(Direccion direccion) : base(direccion) {}


		public void Guardar(string valor) {
			Dato dato = new Dato();
			dato.valor = valor;
			Guardar(dato);
		}


		[System.Serializable]
		public class Dato {

			public string valor;

		}
		

	}

}