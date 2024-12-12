using UnityEngine;

namespace Ging1991.Contadores {

	public class Contador : MonoBehaviour {

		public void SetColor(Color color) {

			foreach (Transform hijo in transform) {
				ContadorIndividual contador = hijo.GetComponent<ContadorIndividual>();
				contador?.SetColor(color);
			}
		}


		public void SetValor(int cantidad) {
			int index = 0;
			foreach (Transform hijo in transform) {
				ContadorIndividual contador = hijo.GetComponent<ContadorIndividual>();
				contador?.SetValor(cantidad > index);
				index++;
			}
		}


		public void SetCantidadMaxima(int cantidadVisible, int cantidadHabilitada) {
			int index = 0;
			Debug.Log(cantidadHabilitada);
			foreach (Transform hijo in transform) {

				// Manejar visibilidad
				hijo.gameObject.SetActive(index < cantidadVisible);

				// Manejar habilitación
				ContadorIndividual contador = hijo.GetComponent<ContadorIndividual>();
				if (contador != null && index >= cantidadHabilitada) {
					contador.SetInhabilitado();
				}

				index++;
			}
		}


	}

}