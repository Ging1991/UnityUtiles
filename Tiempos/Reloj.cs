using UnityEngine;
using System.Collections.Generic;

namespace Ging1991.Tiempos {

	public class Reloj : MonoBehaviour {

		public List<IRelojDecimas> objetosPorDecima = new List<IRelojDecimas>();
		public List<IRelojSegundos> objetosPorSegundo = new List<IRelojSegundos>();
		public List<IRelojMinutos> objetosPorMinuto = new List<IRelojMinutos>();

		private float marcaDecimas;
		private float marcaSegundos;
		private float marcaMinutos;
		
		private readonly float intervaloDecimas = 0.1f;
		private readonly float intervaloSegundos = 1f;
		private readonly float intervaloMinutos = 30f;
		
		public static string NOMBRE_RELOJ = "RelojGlobal";


		void Start() {
			marcaMinutos = Time.time;
			marcaSegundos = Time.time;
			marcaDecimas = Time.time;
		}


		void Update() {

			ProcesarObjetosPorDecimas();
			ProcesarObjetosPorSegundos();
			ProcesarObjetosPorMinutos();

		}


		private void ProcesarObjetosPorDecimas() {
			if (Time.time - marcaDecimas >= intervaloDecimas) {
				List<IRelojDecimas> lista = new List<IRelojDecimas>(objetosPorDecima);
				foreach (IRelojDecimas temporal in lista){
					temporal?.HaPasadoUnaDecima();
				}
				marcaDecimas = Time.time;
			}
		}


		private void ProcesarObjetosPorSegundos() {
			if (Time.time - marcaSegundos >= intervaloSegundos) {
				List<IRelojSegundos> lista = new List<IRelojSegundos>(objetosPorSegundo);
				foreach (IRelojSegundos temporal in lista){
					temporal?.HaPasadoUnSegundo();
				}
				marcaSegundos = Time.time;
			}
		}


		private void ProcesarObjetosPorMinutos() {
			if (Time.time - marcaMinutos >= intervaloMinutos) {
				List<IRelojMinutos> lista = new List<IRelojMinutos>(objetosPorMinuto);
				foreach (IRelojMinutos temporal in lista){
					temporal?.HaPasadoUnMinuto();
				}
				marcaMinutos = Time.time;
			}
		}


		public void AgregarPorDecima(IRelojDecimas temporal) {
			objetosPorDecima.Add(temporal);
		}


		public void QuitarPorDecima(IRelojDecimas temporal) {
			objetosPorDecima.Remove(temporal);
		}


		public void AgregarPorSegundo(IRelojSegundos temporal) {
			objetosPorSegundo.Add(temporal);
		}


		public void QuitarPorSegundo(IRelojSegundos temporal) {
			objetosPorSegundo.Remove(temporal);
		}


		public void AgregarPorMinuto(IRelojMinutos objeto) {
			objetosPorMinuto.Add(objeto);
		}


		public void QuitarPorMinuto(IRelojMinutos objeto) {
			objetosPorMinuto.Remove(objeto);
		}


		public static Reloj GetInstanciaGlobal() {
			return GameObject.Find(NOMBRE_RELOJ).GetComponent<Reloj>();
		}


	}

}