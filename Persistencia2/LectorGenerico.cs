using UnityEngine;

namespace Caballero.Persistencia {
		
	public class LectorGenerico<T> : LectorJSON {

		private T dato;

		public LectorGenerico(string carpeta, string archivo) {
			Inicializar(carpeta, archivo);
		}


		protected T Leer() {
			dato = JsonUtility.FromJson<T>(LeerJSON());
			return dato;
		}


		protected void Guardar(T dato) {
			GuardarJSON(JsonUtility.ToJson(dato));
		}


	}

}