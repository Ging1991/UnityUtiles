using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI {

	public class Casilla : MonoBehaviour {

		public Sprite imgActivado, imgDesactivado;
		public bool activado;
		public string codigo;
		public List<CasillaObservador> observadores;


		public void Iniciar() {
			activado = false;
			observadores = new List<CasillaObservador>();
		}


		public void AgregarObservador (CasillaObservador observador) {
			observadores.Add(observador);
		}


		void OnMouseDown() {
			if (activado) {
				activado = false;
				GetComponentInChildren<Image>().sprite = imgDesactivado;
			} else {
				activado = true;
				GetComponentInChildren<Image>().sprite = imgActivado;
			}

			foreach (CasillaObservador observador in observadores) {
				observador.PresionarCasilla(codigo);
			}
		}


		public static bool EstaActivada (string codigo) {
			GameObject[] arreglo = GameObject.FindGameObjectsWithTag("casilla");
			bool ret = false;
			for (var i = 0; i < arreglo.Length; i++) {
				Casilla casillaActual = arreglo[i].GetComponent<Casilla>();
				if (casillaActual.codigo == codigo)
					ret = casillaActual.activado;
			}
			return ret;
		}


	}

}