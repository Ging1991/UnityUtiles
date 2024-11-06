using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Animaciones {

	public class ImagenMaster : MonoBehaviour {

		public enum Tipo {SPRITE, IMAGEN}
		protected SpriteRenderer componenteSprite;
		protected Image componenteImagen;
		protected Tipo tipo;

		public void Inicializar() {
			componenteImagen = GetComponent<Image>();
			componenteSprite = GetComponent<SpriteRenderer>();
			RevisarCondiciones();
		}


		public void SetImagen(Sprite imagen) {
			if (tipo == Tipo.SPRITE)
				componenteSprite.sprite = imagen;
			if (tipo == Tipo.IMAGEN)
				componenteImagen.sprite = imagen;
		}


		private void RevisarCondiciones() {
			if (tipo == Tipo.SPRITE && componenteSprite == null)
				throw new System.Exception("Este objeto debería contener un SpriteRenderer");
			if (tipo == Tipo.IMAGEN && componenteImagen == null)
				throw new System.Exception("Este objeto debería contener un Image");
		}


	}
		
}