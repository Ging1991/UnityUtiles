using UnityEngine;

namespace Caballero.Persistencia {
		
	public class LectorCadena : Lector {

		private DatoCadena dato;

		public LectorCadena(string carpeta, string archivo, Modo modo) {
			this.modo = modo;
			Inicializar(carpeta, archivo, defecto:JsonUtility.ToJson(new DatoCadena()));
			string datos = Leer();
			if (datos == "")
				dato = new DatoCadena();
			else
				dato = JsonUtility.FromJson<DatoCadena>(datos);
		}


		public DatoCadena LeerDatos() {
			return dato;
		}


		public void GuardarDatos() {
			Guardar(JsonUtility.ToJson(dato));
		}


		public override void Descartar() {
			dato = JsonUtility.FromJson<DatoCadena>(Leer());
		}
		

	}

}