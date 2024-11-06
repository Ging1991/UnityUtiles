using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI.Indicador {

	public class IndicadorDiamante : MonoBehaviour {

		public Sprite imgActivo, imgInactivo;


		public void SetValor(bool activo) {
			GetComponent<Image>().sprite = activo ? imgActivo : imgInactivo;
		}


	}

}