using UnityEngine;

namespace Ging1991.Persistencia {
		
	public abstract class LectorGenerico<T> : LectorStream {

		private T dato;

		public LectorGenerico(string direccion, string direccionInicializacion = "") : base(direccion) {
			if (!ExistenDatos() && direccionInicializacion != "") {
				InicializarDesdeRecursos(direccionInicializacion);
			}
		}


		public T Leer() {
			if (dato == null) {
				dato = JsonUtility.FromJson<T>(LeerDesdeStream());
			}
			return dato;
		}


		public void Descartar() {
			dato = JsonUtility.FromJson<T>(LeerDesdeStream());
		}


		public void Guardar(T dato) {
			GuardarHaciaStream(JsonUtility.ToJson(dato));
		}


		public void InicializarDesdeRecursos(string direccion) {
			string datos = LectorRecursos<T>.LeerCadena(direccion);
			GuardarHaciaStream(datos);
		}


	}

}