using System.IO;
using UnityEngine;

namespace Ging1991.Persistencia {

	public class LectorSprites {


		public static Sprite Leer(string carpeta, string archivo) {
			string direccion = Path.ChangeExtension(carpeta + "\\" + archivo, null);
			return (Sprite) Resources.Load(direccion, typeof(Sprite));
		}


	}

}