//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// AnimeTv.cs (29/08/2018)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase base para los animes de TV.							\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio.Clases
{
	/// <summary>
	/// <para>Clase base para los animes de TV.</para>
	/// </summary>
	[System.Serializable]
	public class AnimeTv
	{
		#region Variables Publicas
		public string nombre = string.Empty;
		public Categoria categoriaI = Categoria.Null;
		public Categoria categoriaII = Categoria.Null;
		public Categoria categoriaIII = Categoria.Null;
		public string compania = string.Empty;
		public string sinopsis = string.Empty;
		public Origen origen = Origen.Null;
		public string fecha = string.Empty;
		public string dia = string.Empty;
		public Sprite img;
		#endregion
	}
}