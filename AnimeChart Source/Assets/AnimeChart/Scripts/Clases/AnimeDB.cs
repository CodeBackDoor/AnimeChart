//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// AnimeDB.cs (29/08/2018)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Data contenedora de los animes.								\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections.Generic;
using MoonAntonio.Clases;
#endregion

namespace MoonAntonio.Data
{
	/// <summary>
	/// <para>Data contenedora de los animes.</para>
	/// </summary>
	[CreateAssetMenu(fileName = "AnimeDB", menuName = "Create/AnimeDB", order = 1)]
	public class AnimeDB : ScriptableObject 
	{
		#region Variables Publicas
		public string nombreObjeto = "New AnimeDB";
		public List<AnimeTv> listaAnimeTV = new List<AnimeTv>();
		public List<AnimeOVA> listaAnimeOVA = new List<AnimeOVA>();
		public List<AnimeMovie> listaAnimeMovie = new List<AnimeMovie>();
		#endregion
	}
}