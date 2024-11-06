using UnityEngine;

namespace Caballero.Persistencia {
		
	public class LectorBooleano : Lector {
		
		private DatoBooleano dato;

		public LectorBooleano(string carpeta, string archivo, Modo modo) {
			this.modo = modo;
			Inicializar(carpeta, archivo, defecto:JsonUtility.ToJson(new DatoBooleano()));
			dato = JsonUtility.FromJson<DatoBooleano>(Leer());
		}


		public DatoBooleano LeerDatos() {
			return dato;
		}


		public void GuardarDatos() {
			Guardar(JsonUtility.ToJson(dato));
		}

		public override void Descartar() {
			dato = JsonUtility.FromJson<DatoBooleano>(Leer());
		}

	}

}