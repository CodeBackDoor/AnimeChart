//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// EntradaMOVIE.cs (03/09/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Componente que se encarga de los datos de la entrada MOVIE.	\\
// Fecha Mod:		03/09/2018													\\
// Ultima Mod:		Version Inicial.											\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace MoonAntonio.Comun
{
	/// <summary>
	/// <para>Componente que se encarga de los datos de la entrada MOVIE.</para>
	/// </summary>
	public class EntradaMOVIE : MonoBehaviour 
	{
		#region Variables Publicas
		public Text txtNombre;
		public Image img;
		public Text compa;
		public Text fecha;
		public Text dia;
		#endregion

		#region Init
		public void Init(string nom, Sprite imagen, string com, string fech, string di)
		{
			txtNombre.text = nom;
			img.sprite = imagen;
			compa.text = com;
			fecha.text = fech;
			dia.text = di;
		}
		#endregion
	}
}