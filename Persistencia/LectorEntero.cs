using UnityEngine;

namespace Caballero.Persistencia {
		
	public class LectorEntero : Lector {

		private DatoEntero dato;

		public LectorEntero(string carpeta, string archivo, Modo modo) {
			this.modo = modo;
			Inicializar(carpeta, archivo, defecto:JsonUtility.ToJson(new DatoEntero()));
			dato = JsonUtility.FromJson<DatoEntero>(Leer());
		}


		public DatoEntero LeerDatos() {
			return dato;
		}


		public void GuardarDatos() {
			Guardar(JsonUtility.ToJson(dato));
		}

		public override void Descartar() {
			dato = JsonUtility.FromJson<DatoEntero>(Leer());
		}



	}

}