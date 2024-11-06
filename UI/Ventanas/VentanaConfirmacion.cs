namespace Ging1991.UI.Ventanas {

	public class VentanaConfirmacion : Ventana {

		public IPresionarBoton accionConfirmar;
		public IPresionarBoton accionRechazar;


		public void BotonConfirmar() {
			if (accionConfirmar != null) {
				accionConfirmar.PresionarBoton(Boton.CONFIRMAR);
			}
			FinalizarVentana();
		}


		public void BotonRechazar() {
			if (accionRechazar != null) {
				accionRechazar.PresionarBoton(Boton.CANCELAR);
			}
			FinalizarVentana();
		}


	}

}