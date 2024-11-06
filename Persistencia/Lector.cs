using System;
using System.IO;
using UnityEngine;

namespace Caballero.Persistencia {

	public abstract class Lector {

		public enum Modo {SOLO_LECTURA, LECTURA_ESCRITURA, ESCRITURA_CON_INICIALIZACION}
		protected Modo modo;
		protected string direccionArchivoPersistencia;
		protected string direccionArchivoRecursos;
		protected string DIRECCION_CARPETA = "\\TEMPORAL\\";


		protected void Inicializar(string carpeta, string archivo, string defecto = "") {
			
			if (modo == Modo.SOLO_LECTURA || modo == Modo.ESCRITURA_CON_INICIALIZACION) {
				direccionArchivoRecursos = Path.ChangeExtension(carpeta + "\\" + archivo, null);
			}

			if (modo == Modo.LECTURA_ESCRITURA || modo == Modo.ESCRITURA_CON_INICIALIZACION) {
				InicializarCarpeta(carpeta);
				direccionArchivoPersistencia = GenerarDireccionPersistente(carpeta + "\\" + archivo);
				if (!File.Exists(direccionArchivoPersistencia)) {
					if (modo == Modo.ESCRITURA_CON_INICIALIZACION)
						Guardar(LeerDesdeRecursos());
					else
						Guardar(defecto);
				}
			}

		}


		protected string Leer() {
			if (modo == Modo.SOLO_LECTURA) {
				return LeerDesdeRecursos();
			}
			return LeerDesdeTemporal();
		}


		protected string LeerDesdeRecursos() {
			TextAsset recurso = (TextAsset) Resources.Load(direccionArchivoRecursos, typeof(TextAsset));
			if (recurso == null) {
				Debug.Log("No se encontro ningun dato en: " + direccionArchivoRecursos);
				return "";
			}
			return recurso.text;
		}


		protected string LeerDesdeTemporal() {
			return File.ReadAllText(direccionArchivoPersistencia);
		}

		
		protected void Guardar(string contenido) {
			if (modo == Modo.SOLO_LECTURA)
				throw new Exception("No se pueden guardar los datos porque esta en modo solo lectura");
			File.WriteAllText(direccionArchivoPersistencia, contenido);
		}


		public abstract void Descartar();


		private string GenerarDireccionPersistente (string archivo) {
			string direccion = (Application.platform == RuntimePlatform.Android ? (Application.persistentDataPath) : Application.dataPath);			
			return direccion + DIRECCION_CARPETA + archivo;
		}


		private void InicializarCarpeta(string direccion) {
			string direccionPersistente = GenerarDireccionPersistente(direccion);
			if (!Directory.Exists(direccionPersistente)) {
				Debug.Log("Lector: No existia la carpeta");
				Directory.CreateDirectory(direccionPersistente);
				Debug.Log("Lector: La carpeta se ha creado correctamente en " + direccionPersistente);
			}
		}

	}


}