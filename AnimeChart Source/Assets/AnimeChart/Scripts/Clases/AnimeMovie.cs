//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// AnimeMovie.cs (29/08/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase base para los animes Movies.							\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio.Clases
{
	/// <summary>
	/// <para>Clase base para los animes Movies.</para>
	/// </summary>
	[System.Serializable]
	public class AnimeMovie 
	{
		#region Variables Publicas
		public string nombre = string.Empty;
		public string compania = string.Empty;
		public string fecha = string.Empty;
		public string dia = string.Empty;
		public Sprite img;
		#endregion
	}
}