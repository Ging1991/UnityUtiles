using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.UI {

	public class BloqueadorRaton : MonoBehaviour {

		public List<string> grupos = new List<string>() {"GLOBAL"};
		private int capaOriginal;
		private int capaBloqueadora;
		public static readonly string CAPA_BLOQUEADORA = "Ignore Raycast";

		void Start() {
			capaOriginal = gameObject.layer;
			capaBloqueadora = LayerMask.NameToLayer(CAPA_BLOQUEADORA);
		}


		public void Bloquear(bool debeBloquear) {
			gameObject.layer = debeBloquear ? capaBloqueadora : capaOriginal;
		}


		public static void BloquearTodos(string grupo, bool debeBloquear) {
			BloqueadorRaton[] bloqueadores = FindObjectsOfType<BloqueadorRaton>();
			foreach (BloqueadorRaton bloqueador in bloqueadores) {
				if (bloqueador.grupos.Contains(grupo)) {
					bloqueador.Bloquear(debeBloquear);
				}
			}
		}


	}

}