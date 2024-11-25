using System.IO;
using UnityEngine;

namespace Caballero.Persistencia {

	public abstract class LectorJSON {

		protected string direccion;
		protected string DIRECCION_CARPETA = "\\TEMPORAL\\";


		protected void Inicializar(string carpeta, string archivo, string defecto = "") {
			InicializarCarpeta(carpeta);
			direccion = GenerarDireccionFinal(carpeta + "\\" + archivo);
			if (!File.Exists(direccion)) {
				GuardarJSON(defecto);
			}
		}


		protected string LeerJSON() {
			return File.ReadAllText(direccion);
		}

		
		protected void GuardarJSON(string contenido) {
			File.WriteAllText(direccion, contenido);
		}


		private string GenerarDireccionFinal (string direccion) {
			string plataforma = (Application.platform == RuntimePlatform.Android ? (Application.persistentDataPath) : Application.dataPath);			
			return plataforma + DIRECCION_CARPETA + direccion;
		}


		private void InicializarCarpeta(string carpeta) {
			string direccion = GenerarDireccionFinal(carpeta);
			if (!Directory.Exists(direccion)) {
				Directory.CreateDirectory(direccion);
				Debug.Log("LectorJSON: La carpeta se ha creado correctamente en " + direccion);
			}
		}

	}


}