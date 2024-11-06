using UnityEngine;

namespace Ging1991.Sonidos {

	public class EfectosDeSonido {


		public static void Tocar(string nombreSonido) {
			GameObject objeto = GameObject.Find(nombreSonido);
			if (objeto != null)
				objeto.GetComponent<AudioSource>().Play();
			else
				Debug.LogError($"No se encontró en la escena el objeto: {nombreSonido}");
		}


	}

}