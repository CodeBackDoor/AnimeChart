//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// AnimeOVA.cs (29/08/2018)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase base para los animes OVA.								\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio.Clases
{
	/// <summary>
	/// <para>Clase base para los animes OVA.</para>
	/// </summary>
	[System.Serializable]
	public class AnimeOVA
	{
		#region Variables Publicas
		public string nombre = string.Empty;
		public string compania = string.Empty;
		public string sinopsis = string.Empty;
		public CategoriaEspecial categoria = CategoriaEspecial.Null;
		public string fecha = string.Empty;
		public string dia = string.Empty;
		public Sprite img;
		#endregion
	}
}