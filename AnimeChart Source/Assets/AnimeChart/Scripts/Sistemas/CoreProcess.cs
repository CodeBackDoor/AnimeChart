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
		public GameObject prefabTv;
		public GameObject prefabOva;
		public GameObject prefabMovie;
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

		public void CargarDefault()
		{
			txtTemporada.text = "Primavera";
			txtTemporada.fontSize = 91;
			txtTemporada.fontStyle = FontStyle.Bold;
			txtAno.text = "2016";
			txtAno.fontSize = 91;
			txtAno.fontStyle = FontStyle.Bold;
			txtAno.color = new Color(103, 135, 253, 255);
			txtNombre.text = "ANIME CHART";
			txtNombre.fontSize = 91;
			txtNombre.fontStyle = FontStyle.Bold;
			txtVersion.text = "Version <color=green>2.0</color> -";
			txtVersion.fontSize = 10;
			txtVersion.fontStyle = FontStyle.Normal;
			txtDateVersion.text = "02.05.2018";
			txtDateVersion.fontSize = 91;
			txtDateVersion.fontStyle = FontStyle.Normal;
			txtFirma.text = "Chart by AntonioMoon @ <color=green>moonantonio.github.io</color>";
			txtFirma.fontSize = 20;
			txtFirma.fontStyle = FontStyle.Bold;
		}
		#endregion
	}
}