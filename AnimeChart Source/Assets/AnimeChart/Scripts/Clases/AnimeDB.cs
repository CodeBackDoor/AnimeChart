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
	[CreateAssetMenu(fileName = "AnimeDB", menuName = "AnimeData/AnimeDB", order = 1)]
	public class AnimeDB : ScriptableObject 
	{
		#region Variables Publicas
		public string nombreObjeto = "New AnimeDB";
		public string temporada = "Verano";
		public Meses mesInicio = Meses.Null;
		public Meses mesFinal = Meses.Null;
		public Ano anoInicio = Ano.Null;
		public Ano anoFinal = Ano.Null;
		public string versionDoc = "Version <color=green>2.0</color> - ";
		public string fechaDoc = "19/08/2018";
		public string firma = "Chart by AntonioMoon @ <color=green>moonantonio.github.io</color>";
		public string sourceTemplate = "Source: XXXXX • XXXXX • XXXX   ";
		public List<AnimeTv> listaAnimeTV = new List<AnimeTv>();
		public List<AnimeOVA> listaAnimeOVA = new List<AnimeOVA>();
		public List<AnimeMovie> listaAnimeMovie = new List<AnimeMovie>();
		#endregion
	}
}