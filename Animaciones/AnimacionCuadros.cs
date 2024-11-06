using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Animaciones {

	public class AnimacionCuadros : Animacion {

		private readonly List<Sprite> cuadros;
		private int cuadroActual;

        public AnimacionCuadros(List<Sprite> cuadros, int salto, ImagenMaster imagenMaster) :
				base(imagenMaster, salto) {

			this.cuadros = cuadros;
			cuadroActual = 0;
			imagenMaster.SetImagen(cuadros[cuadroActual]);
        }


		protected override void AvanzarCuadro() {
			cuadroActual++;
			if (cuadroActual >= cuadros.Count)
				cuadroActual = 0;
			imagenMaster.SetImagen(cuadros[cuadroActual]);
		}


	}

}