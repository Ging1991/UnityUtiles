using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Animaciones {

	public class EfectoVisual : MonoBehaviour {

		public List<GameObject> efectos;

		public void Animar(string codigo) {
			GameObject instancia = null;
			foreach (GameObject efecto in efectos) {
				if (efecto.GetComponent<Animador>().codigo == codigo) {
					instancia = efecto;
					break;
				}
			}
			if (instancia != null) {
				instancia.GetComponent<Animador>().Inicializar();
			} else {
				Debug.LogError("No se encontro un efecto con el codigo");
			}
		}



	}

}