using System.IO;
using UnityEngine;

namespace Ging1991.Persistencia {

	public class Direccion {

		private readonly string carpeta;
		private readonly string archivo;
		protected string carpetaBase;
		public enum Tipo {
			LECTOESCRITURA,
			RECURSOS
		}
		private readonly Tipo tipo;


		public Direccion(string carpeta, string archivo, Tipo tipo) {
			this.carpeta = carpeta;
			this.archivo = archivo;
			this.tipo = tipo;
			InicializarCarpeta();
		}


		public string Generar() {
			carpetaBase = "\\TEMPORAL\\";
			if (tipo == Tipo.RECURSOS)
				carpetaBase = "";
			return $"{GetPlataforma()}{carpetaBase}\\{carpeta}\\{archivo}";
		}


		private void InicializarCarpeta() {
			string direccion = GetPlataforma() + carpetaBase + carpeta;
			if (!Directory.Exists(direccion)) {
				Directory.CreateDirectory(direccion);
				Debug.Log("Direccion: La carpeta se ha creado correctamente en " + direccion);
			}
		}


		public static string GetPlataforma() {
			return (Application.platform == RuntimePlatform.Android ? (Application.persistentDataPath) : Application.dataPath);
		}


	}


}