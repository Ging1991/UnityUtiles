using UnityEngine;

namespace Caballero.Persistencia {
		
	public class LectorListaEnteros : Lector {
		
		private DatoListaEnteros dato;

		public LectorListaEnteros(string carpeta, string archivo, Modo modo) {
			this.modo = modo;
			Inicializar(carpeta, archivo, defecto:JsonUtility.ToJson(new DatoListaEnteros()));
			dato = JsonUtility.FromJson<DatoListaEnteros>(Leer());
		}


		public DatoListaEnteros LeerDatos() {
			return dato;
		}


		public void GuardarDatos() {
			Guardar(JsonUtility.ToJson(dato));
		}


		public override void Descartar() {
			dato = JsonUtility.FromJson<DatoListaEnteros>(Leer());
		}

	}

}