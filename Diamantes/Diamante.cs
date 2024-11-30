using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Diamantes {

	public class Diamante : MonoBehaviour {

		public Sprite imgActivo, imgInactivo, imgDeshabilitado;

		public void SetColor(Color color) {
			GetComponent<Image>().color = color;
		}


		public void SetValor(bool estaActivo) {
			GetComponent<Image>().sprite = estaActivo ? imgActivo : imgInactivo;
		}


		public void Deshabilitar() {
			GetComponent<Image>().sprite = imgDeshabilitado;
		}


	}

}