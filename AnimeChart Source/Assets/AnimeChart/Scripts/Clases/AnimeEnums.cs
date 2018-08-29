//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// AnimeEnums.cs (29/08/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Data contenedora de los animes.								\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	public enum Temporada
	{
		Null,
		Summer2018,
		Autumn2018,
		Winter2018
	}

	public enum Meses
	{
		Null,
		Enero,
		Febrero,
		Marzo,
		Abril,
		Mayo,
		Junio,
		Julio,
		Agosto,
		Septiembre,
		Octubre,
		Noviembre,
		Diciembre
	}

	public enum Ano
	{
		Null,
		A2018,
		A2019
	}

	public enum Categoria
	{
		Null,
		Accion,
		Fantasia
	}

	public enum CategoriaEspecial
	{
		Null,
		OVA,
		SP,
		OAD
	}

	public enum Origen
	{
		Null,
		Original,
		Manga,
		Novela,
		Juego,
	}
}