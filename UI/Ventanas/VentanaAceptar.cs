namespace Ging1991.UI.Ventanas {

	public class VentanaAceptar : Ventana {

		public IPresionarBoton accionAceptar;


		public void BotonAceptar() {
			if (accionAceptar != null) {
				accionAceptar.PresionarBoton(Boton.ACEPTAR);
			}
			FinalizarVentana();
		}


	}

}