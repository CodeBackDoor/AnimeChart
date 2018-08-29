//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// CoreProcess.cs (29/08/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Sistema que genera la imagen a partir de la camara.			\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using MoonAntonio.Data;
#endregion

namespace MoonAntonio.Sistemas
{
	/// <summary>
	/// <para>Sistema que genera la imagen a partir de la camara.</para>
	/// </summary>
	public class CoreProcess : MonoBehaviour 
	{
		#region Variables Publicas
		public AnimeDB db;
		public Text txtTemporada;
		public Text txtAno;
		public Text txtNombre;
		public Text txtVersion;
		public Text txtDateVersion;
		public Text txtFirma;
		public Text txtMesInicio;
		public Text txtAnoInicio;
		public Text txtMesFinal;
		public Text txtAnoFinal;
		public Text txtSource;
		public Transform rootTV;
		public Transform rootOVA;
		public Transform rootMOVIE;
		#endregion

		#region API
		public void GenerarChart() { }
		public void CrearFoto() { }
		#endregion
	}
}