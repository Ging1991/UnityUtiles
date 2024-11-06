using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class Simbolo : MonoBehaviour {


		public void SetTexto(string texto) {
			GetComponentInChildren<Text>().text = texto;
		}


		public void SetImagen(Sprite imagen) {
			GetComponentInChildren<Image>().sprite = imagen;
		}


		public static Simbolo GetSimbolo(string nombre) {
			return GameObject.Find(nombre).GetComponent<Simbolo>();
		}


	}

}