using System.IO;

namespace Ging1991.Persistencia {

	public abstract class LectorStream {

		private readonly string direccion;

		public LectorStream(string direccion) {
			this.direccion = direccion;
		}


		public bool ExistenDatos() {
			return File.Exists(direccion);
		}


		protected string LeerDesdeStream() {
			return File.ReadAllText(direccion);
		}

		
		protected void GuardarHaciaStream(string contenido) {
			File.WriteAllText(direccion, contenido);
		}


	}

}