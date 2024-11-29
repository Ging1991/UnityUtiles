using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Casillas {

	public class GrupoDeCasillas : MonoBehaviour, ICasillaObservador {

		private readonly List<Casilla> casillas;
		private List<ICasillaObservador> observadores;
		public string codigo;


		public void Iniciar() {
			observadores = new List<ICasillaObservador>();
			foreach (var casilla in casillas) {
				casilla.AgregarObservador(this);
			}
		}


		public void AgregarObservador (ICasillaObservador observador) {
			observadores.Add(observador);
		}


		public List<string> GetCasillasActivas() {
			List<string> ret = new List<string>();
			foreach(var casilla in casillas) {
				if (casilla.valor == true)
					ret.Add(casilla.codigo);
			}
			return ret;
		}


        public void PresionarCasilla(string codigo, bool valor) {
			foreach (ICasillaObservador observador in observadores) {
				observador.PresionarCasilla(codigo, valor);
			}
        }


    }

}