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
using MoonAntonio.Comun;
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
		public void GenerarChart()
		{
			Clear();

			txtTemporada.text = db.temporada;
			txtAno.text = db.anoInicio.ToString();
			txtNombre.text = "ANIME CHART";
			txtVersion.text = db.versionDoc;
			txtDateVersion.text = db.fechaDoc;
			txtFirma.text = db.firma;
			txtMesInicio.text = db.mesInicio.ToString();
			txtMesFinal.text = db.mesFinal.ToString();
			txtAnoInicio.text = db.anoInicio.ToString();
			txtAnoFinal.text = db.anoFinal.ToString();
			txtSource.text = db.sourceTemplate.ToString();

			for (int n = 0; n < db.listaAnimeTV.Count; n++)
			{
				GameObject go = Instantiate(prefabTv, rootTV);
				go.GetComponent<EntradaTV>().Init(db.listaAnimeTV[n].nombre, db.listaAnimeTV[n].img, db.listaAnimeTV[n].categoriaI,
												db.listaAnimeTV[n].categoriaII, db.listaAnimeTV[n].categoriaIII, db.listaAnimeTV[n].compania,
												db.listaAnimeTV[n].sinopsis, db.listaAnimeTV[n].origen, db.listaAnimeTV[n].fecha, db.listaAnimeTV[n].dia);

				go.name = string.Format("EntradaTV :: {0}-{1}", db.listaAnimeTV[n].nombre,n);
			}

			for (int n = 0; n < db.listaAnimeOVA.Count; n++)
			{
				GameObject go = Instantiate(prefabOva, rootOVA);
				go.GetComponent<EntradaOVA>().Init(db.listaAnimeOVA[n].nombre, db.listaAnimeOVA[n].img, db.listaAnimeOVA[n].compania,
								db.listaAnimeOVA[n].sinopsis, db.listaAnimeOVA[n].categoria, db.listaAnimeOVA[n].fecha, db.listaAnimeOVA[n].dia);

				go.name = string.Format("EntradaOVA :: {0}-{1}", db.listaAnimeOVA[n].nombre, n);

			}

			for (int n = 0; n < db.listaAnimeMovie.Count; n++)
			{
				GameObject go = Instantiate(prefabMovie, rootMOVIE);
				go.GetComponent<EntradaMOVIE>().Init(db.listaAnimeMovie[n].nombre, db.listaAnimeMovie[n].img, db.listaAnimeMovie[n].compania, db.listaAnimeMovie[n].fecha, db.listaAnimeMovie[n].dia);

				go.name = string.Format("EntradaMOVIE :: {0}-{1}", db.listaAnimeMovie[n].nombre, n);

			}
		}

		public void CrearFoto()
		{
			ScreenCapture.CaptureScreenshot(db.nombreObjeto + ".png");
		}

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
			txtMesInicio.text = "Septiembre";
			txtMesInicio.fontSize = 10;
			txtMesInicio.fontStyle = FontStyle.Normal;
			txtAnoInicio.text = "2018";
			txtAnoInicio.fontSize = 30;
			txtAnoInicio.fontStyle = FontStyle.Normal;
			txtMesFinal.text = "Noviembre";
			txtMesFinal.fontSize = 10;
			txtMesFinal.fontStyle = FontStyle.Normal;
			txtAnoFinal.text = "2018";
			txtAnoFinal.fontSize = 10;
			txtAnoFinal.fontStyle = FontStyle.Normal;
			txtSource.text = "Source : MyAnimeList • XXXXXX • XXXXX   ";
			txtSource.fontSize = 10;
			txtSource.fontStyle = FontStyle.Normal;

			for (int n = 0; n < 36; n++)
			{
				Instantiate(prefabTv, rootTV);
			}

			for (int n = 0; n < 38; n++)
			{
				Instantiate(prefabOva, rootOVA);
			}

			for (int n = 0; n < 14; n++)
			{
				Instantiate(prefabMovie, rootMOVIE);
			}
		}

		public void Clear()
		{
			foreach (Transform child in rootTV)
			{
				DestroyImmediate(child.gameObject);
			}

			foreach (Transform child in rootOVA)
			{
				DestroyImmediate(child.gameObject);
			}

			foreach (Transform child in rootMOVIE)
			{
				DestroyImmediate(child.gameObject);
			}
		}
		#endregion
	}
}