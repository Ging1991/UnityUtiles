using System.IO;

namespace Ging1991.Persistencia {

	public abstract class LectorJSON {

		private string direccion;


		protected void Inicializar(Direccion direccion, string defecto = "") {
			this.direccion = direccion.Generar();
			if (!File.Exists(this.direccion)) {
				GuardarJSON(defecto);
			}
		}


		protected string LeerJSON() {
			return File.ReadAllText(direccion);
		}

		
		protected void GuardarJSON(string contenido) {
			File.WriteAllText(direccion, contenido);
		}

	}


}