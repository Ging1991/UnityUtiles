using System;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.UI.Ventanas {

	public abstract class Ventana : MonoBehaviour {

		public GameObject objVentanaAceptar;
		public GameObject objVentanaConfirmar;
		public GameObject objVentanaOpcionMultiple;
		public static string LIENZO = "LienzoVentanas";
		public static string VENTANA_CONTROL = "VentanaControl";
		public enum Tipo {
			ACEPTAR,
			CONFIRMAR,
			OPCION_MULTIPLE
		}
		public Tipo tipo;


		private static GameObject InstanciarVentana(GameObject obj, string nombre, string texto) {
			GameObject instancia = Instantiate(obj, Vector3.zero, Quaternion.identity);
			instancia.transform.SetParent(GameObject.Find(LIENZO).transform);
			instancia.transform.localPosition = Vector3.zero;
			instancia.name = nombre;
			instancia.transform.GetChild(0).GetComponent<Text>().text = texto;
			BloqueadorRaton.BloquearTodos("GLOBAL", true);
			return instancia;
		}


		public static GameObject CrearVentanaAceptar(string mensaje, IPresionarBoton accion=null) {
			RevisarRequisitos();
			Ventana control = GameObject.Find(VENTANA_CONTROL).GetComponent<Ventana>();
			GameObject instancia = InstanciarVentana(control.objVentanaAceptar, "VentanaAceptar", mensaje);
			instancia.GetComponent<VentanaAceptar>().accionAceptar = accion;
			return instancia;
		}


		private static void RevisarRequisitos() {
			if (GameObject.Find(VENTANA_CONTROL)  == null) {
				throw new Exception($"No se encontro {VENTANA_CONTROL}, agreguela a la escena desde CABALLERO/UI/VENTANAS/OBJETOS");
			}
			if (GameObject.Find(LIENZO)  == null) {
				throw new Exception($"No se encontro {LIENZO}, creelo en la escena con el nombre correspondiente");
			}
		}


		public static GameObject CrearVentanaConfirmar(string mensaje, IPresionarBoton accionConfirmar=null, IPresionarBoton accionCancelar=null) {
			RevisarRequisitos();
			Ventana control = GameObject.Find(VENTANA_CONTROL).GetComponent<Ventana>();
			GameObject instancia = InstanciarVentana(control.objVentanaConfirmar, "VentanaConfirmacion", mensaje);
			instancia.GetComponent<VentanaConfirmacion>().accionConfirmar = accionConfirmar;
			instancia.GetComponent<VentanaConfirmacion>().accionRechazar = accionCancelar;
			return instancia;
		}


		public static GameObject CrearVentanaOpcionMultiple(string mensaje, int cantidadOpciones,
				IPresionarBoton opcion1=null,
				IPresionarBoton opcion2=null,
				IPresionarBoton opcion3=null,
				IPresionarBoton opcion4=null,
				IPresionarBoton opcion5=null) {
			Ventana control = GameObject.Find(VENTANA_CONTROL).GetComponent<Ventana>();
			GameObject instancia = InstanciarVentana(control.objVentanaOpcionMultiple, "VentanaOpcionMultiple", mensaje);
			instancia.GetComponent<VentanaOpcionMultiple>().accionOpcion1 = opcion1;
			instancia.GetComponent<VentanaOpcionMultiple>().accionOpcion2 = opcion2;
			instancia.GetComponent<VentanaOpcionMultiple>().accionOpcion3 = opcion3;
			instancia.GetComponent<VentanaOpcionMultiple>().accionOpcion4 = opcion4;
			instancia.GetComponent<VentanaOpcionMultiple>().accionOpcion5 = opcion5;
			return instancia;
		}


		public void FinalizarVentana() {
			BloqueadorRaton.BloquearTodos("GLOBAL", false);
			Destroy(gameObject);
		}


	}

}