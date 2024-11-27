using UnityEngine;

namespace Ging1991.Persistencia {

	public abstract class LectorRecursos {

		public static string LeerCadena(string direccion) {
			TextAsset recurso = (TextAsset) Resources.Load(direccion, typeof(TextAsset));
			return recurso.text;
		}

		
		public static Sprite LeerSprite(string direccion) {
			return (Sprite) Resources.Load(direccion, typeof(Sprite));
		}


	}

}