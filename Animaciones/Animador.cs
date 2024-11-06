using System.Collections.Generic;
using Ging1991.Sonidos;
using Ging1991.Tiempos;
using UnityEngine;

namespace Ging1991.Animaciones {

	public class Animador : MonoBehaviour, IRelojDecimas {

		public List<Animacion> animaciones;
		public bool esEscalar;
		public float escalaInicial;
		public float escalaFinal;
		public int salto;
		public int duracion;
		private IFinalizarAnimacion accion;
		public string codigo;
		public string sonido;


		public void Inicializar (IFinalizarAnimacion accion = null) {
			EfectosDeSonido.Tocar(sonido);
			this.accion = accion;

			gameObject.SetActive(true);
			animaciones = new List<Animacion>();
			if (esEscalar) {
				animaciones.Add(new AnimacionEscalar(escalaInicial, escalaFinal, salto, duracion, transform, GetComponent<ImagenMaster>()));
			}
			GetComponent<Reloj>().AgregarPorDecima(this);
		}


        public void HaPasadoUnaDecima() {
			bool finalizado = false;
			foreach (Animacion animacion in animaciones) {
				animacion.Animar();
				finalizado = finalizado || animacion.iteraciones >= duracion;
			}
			if (finalizado) {
				Finalizar();
			}
		}


		private void Finalizar() {
			GetComponent<Reloj>().QuitarPorDecima(this);
			gameObject.SetActive(false);
			if (accion != null) {
				accion.FinalizarAnimacion();
			}

		}

    }

}