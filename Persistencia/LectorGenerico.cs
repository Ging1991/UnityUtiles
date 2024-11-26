using UnityEngine;

namespace Ging1991.Persistencia {
		
	public abstract class LectorGenerico<T> : LectorJSON {

		private T dato;

		public LectorGenerico(Direccion direccion) {
			Inicializar(direccion);
		}


		public T Leer() {
			if (dato == null) {
				dato = JsonUtility.FromJson<T>(LeerJSON());
			}
			return dato;
		}


		public void Descartar() {
			dato = JsonUtility.FromJson<T>(LeerJSON());
		}


		public void Guardar(T dato) {
			GuardarJSON(JsonUtility.ToJson(dato));
		}


	}

}