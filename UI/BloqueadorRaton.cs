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
			Debug.Log("Capa bloqueadora: " + capaBloqueadora);
		}


		public void Bloquear(bool debeBloquear) {
			capaBloqueadora = LayerMask.NameToLayer(CAPA_BLOQUEADORA);
			gameObject.layer = debeBloquear ? capaBloqueadora : capaOriginal;
			Debug.Log(gameObject.layer);
		}


		public static void BloquearTodos(string grupo, bool debeBloquear) {
			BloqueadorRaton[] bloqueadores = FindObjectsOfType<BloqueadorRaton>();
			Debug.Log(bloqueadores.Length);
			foreach (BloqueadorRaton bloqueador in bloqueadores) {
				if (bloqueador.grupos.Contains(grupo)) {
					bloqueador.Bloquear(debeBloquear);
				}
			}
		}


	}

}