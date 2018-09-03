//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// EntradaTV.cs (03/09/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Componente que se encarga de los datos de la entrada TV.	\\
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
	/// <para>Componente que se encarga de los datos de la entrada TV.</para>
	/// </summary>
	public class EntradaTV : MonoBehaviour 
	{
		#region Variables Publicas
		public Text txtNombre;
		public Image img;
		public Text cat1;
		public Text cat2;
		public Text cat3;
		public Text compa;
		public Text sinopsis;
		public Text origen;
		public Text fecha;
		public Text dia;
		#endregion

		#region Init
		public void Init(string nom, Sprite imagen, Categoria cate1, Categoria cate2, Categoria cate3, string com, string sinop, Origen ori, string fech, string di)
		{
			txtNombre.text = nom;
			img.sprite = imagen;
			if (cate1 != Categoria.Null) cat1.text = cate1.ToString();
			if (cate2 != Categoria.Null) cat2.text = cate2.ToString();
			if (cate3 != Categoria.Null) cat3.text = cate3.ToString();
			compa.text = com;
			sinopsis.text = sinop;
			origen.text = ori.ToString();
			fecha.text = fech;
			dia.text = di;
		}
		#endregion
	}
}