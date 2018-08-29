//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// CoreProcessInspector.cs (29/08/2018)											\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Inspector de CoreProcess.									\\
// Fecha Mod:		29/08/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEditor;
using MoonAntonio.Sistemas;
using MoonAntonio.Data;
using System;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Inspector de CoreProcess.</para>
	/// </summary>
	[CustomEditor(typeof(CoreProcess))]
	public class CoreProcessInspector : Editor
	{
		private int tab;
		SerializedProperty dbProperty;

		void OnEnable()
		{
			dbProperty = serializedObject.FindProperty("db");
		}

		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			CoreProcess core = (CoreProcess)target;

			tab = GUILayout.Toolbar(tab, new string[] { "Produccion", "Setup", "Ayuda" });
			switch (tab)
			{
				case 0:
					EditorGUI.indentLevel++;

					EditorGUILayout.PropertyField(dbProperty);

					EditorGUI.indentLevel--;

					if (GUILayout.Button("Generar Chart"))
					{
						core.GenerarChart();
					}

					if (GUILayout.Button("Crear Foto"))
					{
						core.CrearFoto();
					}
					break;

				case 1:
					break;

				case 2:
					break;
			}

			serializedObject.ApplyModifiedProperties();
		}

	}
}