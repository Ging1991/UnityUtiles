using UnityEngine;

namespace Ging1991.Diamantes {

	public class IndicadorDiamante : MonoBehaviour {

		public void SetColor(Color color) {
			transform.GetChild(0).GetComponent<Diamante>().SetColor(color);
			transform.GetChild(1).GetComponent<Diamante>().SetColor(color);
			transform.GetChild(2).GetComponent<Diamante>().SetColor(color);
			transform.GetChild(3).GetComponent<Diamante>().SetColor(color);
			transform.GetChild(4).GetComponent<Diamante>().SetColor(color);
		}


		public void SetValor(int cantidad, int cantidadHabilitada, int cantidadVisible) {
			transform.GetChild(0).GetComponent<Diamante>().SetValor(cantidad > 0);
			transform.GetChild(1).GetComponent<Diamante>().SetValor(cantidad > 1);
			transform.GetChild(2).GetComponent<Diamante>().SetValor(cantidad > 2);
			transform.GetChild(3).GetComponent<Diamante>().SetValor(cantidad > 3);
			transform.GetChild(4).GetComponent<Diamante>().SetValor(cantidad > 4);
			SetCantidadHabilitada(cantidadHabilitada);
			SetCantidadVisible(cantidadVisible);
		}


		public void SetCantidadHabilitada(int cantidad) {
			if (cantidad < 1)
				transform.GetChild(0).GetComponent<Diamante>().Deshabilitar();
			if (cantidad < 2)
				transform.GetChild(1).GetComponent<Diamante>().Deshabilitar();
			if (cantidad < 3)
				transform.GetChild(2).GetComponent<Diamante>().Deshabilitar();
			if (cantidad < 4)
				transform.GetChild(3).GetComponent<Diamante>().Deshabilitar();
			if (cantidad < 5)
				transform.GetChild(4).GetComponent<Diamante>().Deshabilitar();
		}


		public void SetCantidadVisible(int cantidad) {
			for (int i = 0; i < transform.childCount; i++) {
				transform.GetChild(i).gameObject.SetActive(i < cantidad);
			}
		}


	}

}