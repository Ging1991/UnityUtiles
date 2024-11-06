namespace Ging1991.UI.Ventanas {

	public class VentanaOpcionMultiple : Ventana {

		public IPresionarBoton accionOpcion1;
		public IPresionarBoton accionOpcion2;
		public IPresionarBoton accionOpcion3;
		public IPresionarBoton accionOpcion4;
		public IPresionarBoton accionOpcion5;


		public void BotonOpcion1() {
			if (accionOpcion1 != null) {
				accionOpcion1.PresionarBoton(Boton.OPCION_1);
			}
			FinalizarVentana();
		}


		public void BotonOpcion2() {
			if (accionOpcion2 != null) {
				accionOpcion2.PresionarBoton(Boton.OPCION_2);
			}
			FinalizarVentana();
		}


		public void BotonOpcion3() {
			if (accionOpcion3 != null) {
				accionOpcion3.PresionarBoton(Boton.OPCION_3);
			}
			FinalizarVentana();
		}


		public void BotonOpcion4() {
			if (accionOpcion4 != null) {
				accionOpcion4.PresionarBoton(Boton.OPCION_4);
			}
			FinalizarVentana();
		}


		public void BotonOpcion5() {
			if (accionOpcion5 != null) {
				accionOpcion5.PresionarBoton(Boton.OPCION_5);
			}
			FinalizarVentana();
		}


	}

}