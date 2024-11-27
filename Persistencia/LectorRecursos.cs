using UnityEngine;

namespace Ging1991.Persistencia {

	public abstract class LectorRecursos<T> {

		private T dato;
		private readonly string direccion;

		public LectorRecursos(string direccion) {
			this.direccion = direccion;
		}


		public T Leer() {
			if (dato == null) {
				dato = JsonUtility.FromJson<T>(LeerCadena(direccion));
			}
			return dato;
		}


		public static string LeerCadena(string direccion) {
			TextAsset recurso = (TextAsset) Resources.Load(direccion, typeof(TextAsset));
			return recurso.text;
		}

		
		public static Sprite LeerSprite(string direccion) {
			return (Sprite) Resources.Load(direccion, typeof(Sprite));
		}


	}

}