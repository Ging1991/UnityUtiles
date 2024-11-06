namespace Ging1991.Animaciones {

	public abstract class Animacion {

		protected int salto;
		private int contador;
		public int iteraciones;
		protected ImagenMaster imagenMaster;

		public Animacion(ImagenMaster imagenMaster, int salto) {
			this.imagenMaster = imagenMaster;
			this.salto = salto;
			this.iteraciones = 0;
		}


		protected abstract void AvanzarCuadro();


        public void Animar() {
			contador++;
			if (contador >= salto) {
				contador = 0;
				AvanzarCuadro();
				iteraciones++;
			}
		}


    }

}