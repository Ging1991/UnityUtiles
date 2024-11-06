using UnityEngine;

namespace Ging1991.Animaciones {

	public class AnimacionEscalar : Animacion {

		private readonly float escalaInicial;
		private readonly int duracion;
		private readonly float escalaFinal;
		private readonly Transform transformador;

        public AnimacionEscalar(float escalaInicial, float escalaFinal, int salto, int duracion,
				Transform transformador, ImagenMaster imagenMaster) :
				base(imagenMaster, salto) {

			this.transformador = transformador;
			this.escalaInicial = escalaInicial;
			this.escalaFinal = escalaFinal;
			this.duracion = duracion;
			this.transformador.localScale = new Vector3(escalaInicial, escalaInicial, escalaInicial);
	    }


		protected override void AvanzarCuadro() {
			float crecimiento = (escalaFinal - escalaInicial) / duracion;
			float nuevaEscala = Mathf.Clamp(transformador.localScale.x + crecimiento, escalaInicial, escalaFinal);
			transformador.localScale = new Vector3(nuevaEscala, nuevaEscala, nuevaEscala);
		}


    }
	
}