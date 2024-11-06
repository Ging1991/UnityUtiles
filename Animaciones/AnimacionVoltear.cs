using UnityEngine;

namespace Ging1991.Animaciones {

	public class AnimacionVoltear : Animacion {
        
		public AnimacionVoltear(ImagenMaster imagenMaster, int velocidad) : base(imagenMaster, velocidad)
        {
        }

		public void DeterminarLado(Vector2 direccion) {
//			Vector2 direccionActual = transform.right;
//			Vector2 direccionHaciaPunto = direccion - (Vector2) transform.position;
//			float productoPunto = Vector2.Dot(direccionActual, direccionHaciaPunto);
//			bool esDerecha = productoPunto > 0;
//			if (tipo == Tipo.SPRITE)
//				componenteSprite.flipX = !esDerecha;
			//if (tipo == Tipo.IMAGEN)
			//	throw new System.Exception("La opcion de voltear horizontalmente no esta adaptada para Imagen, use en su lugar sprite");
		}

        
		protected override void AvanzarCuadro() {}


    }
	
}