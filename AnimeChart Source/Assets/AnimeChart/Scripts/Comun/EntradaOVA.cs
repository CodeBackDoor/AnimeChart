//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// EntradaOVA.cs (03/09/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Componente que se encarga de los datos de la entrada OVA.	\\
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
	/// <para>Componente que se encarga de los datos de la entrada OVA.</para>
	/// </summary>
	public class EntradaOVA : MonoBehaviour 
	{
		#region Variables Publicas
		public Text txtNombre;
		public Image img;
		public Text compa;
		public Text sinopsis;
		public Text origen;
		public Text fecha;
		public Text dia;
		#endregion

		#region Init
		public void Init(string nom, Sprite imagen, string com, string sinop, CategoriaEspecial ori, string fech, string di)
		{
			txtNombre.text = nom;
			img.sprite = imagen;
			compa.text = com;
			sinopsis.text = sinop;
			origen.text = ori.ToString();
			fecha.text = fech;
			dia.text = di;
		}
		#endregion
	}
}