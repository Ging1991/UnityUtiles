using UnityEngine;

namespace Ging1991.UI.Indicador {

	public class Indicador : MonoBehaviour {


		public void SetValor(int cantidad) {
			transform.GetChild(0).GetComponent<IndicadorDiamante>().SetValor(cantidad > 0);
			transform.GetChild(1).GetComponent<IndicadorDiamante>().SetValor(cantidad > 1);
			transform.GetChild(2).GetComponent<IndicadorDiamante>().SetValor(cantidad > 2);
			transform.GetChild(3).GetComponent<IndicadorDiamante>().SetValor(cantidad > 3);
			transform.GetChild(4).GetComponent<IndicadorDiamante>().SetValor(cantidad > 4);
		}


		public void SetCantidadMaxima(int cantidad) {
			transform.GetChild(0).gameObject.SetActive(cantidad > 0);
			transform.GetChild(1).gameObject.SetActive(cantidad > 1);
			transform.GetChild(2).gameObject.SetActive(cantidad > 2);
			transform.GetChild(3).gameObject.SetActive(cantidad > 3);
			transform.GetChild(4).gameObject.SetActive(cantidad > 4);
		}


	}

}