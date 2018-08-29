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
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Inspector de CoreProcess.</para>
	/// </summary>
	[CustomEditor(typeof(CoreProcess))]
	public class CoreProcessInspector : Editor
	{
		#region Variables
		private int tab;
		SerializedProperty dbProperty;
		SerializedProperty txtTemporadaProperty;
		SerializedProperty txtAnoProperty;
		SerializedProperty txtNombreProperty;
		SerializedProperty txtVersionProperty;
		SerializedProperty txtDateVersionProperty;
		SerializedProperty txtFirmaProperty;
		SerializedProperty txtMesInicioProperty;
		SerializedProperty txtAnoInicioProperty;
		SerializedProperty txtMesFinalProperty;
		SerializedProperty txtAnoFinalProperty;
		SerializedProperty txtSourceProperty;
		SerializedProperty rootTVProperty;
		SerializedProperty rootOVAProperty;
		SerializedProperty rootMOVIEProperty;
		#endregion

		#region Eventos
		void OnEnable()
		{
			dbProperty = serializedObject.FindProperty("db");
			txtTemporadaProperty = serializedObject.FindProperty("txtTemporada");
			txtAnoProperty = serializedObject.FindProperty("txtAno");
			txtNombreProperty = serializedObject.FindProperty("txtNombre");
			txtVersionProperty = serializedObject.FindProperty("txtVersion");
			txtDateVersionProperty = serializedObject.FindProperty("txtDateVersion");
			txtFirmaProperty = serializedObject.FindProperty("txtFirma");
			txtMesInicioProperty = serializedObject.FindProperty("txtMesInicio");
			txtAnoInicioProperty = serializedObject.FindProperty("txtAnoInicio");
			txtMesFinalProperty = serializedObject.FindProperty("txtMesFinal");
			txtAnoFinalProperty = serializedObject.FindProperty("txtAnoFinal");
			txtSourceProperty = serializedObject.FindProperty("txtSource");
			rootTVProperty = serializedObject.FindProperty("rootTV");
			rootOVAProperty = serializedObject.FindProperty("rootOVA");
			rootMOVIEProperty = serializedObject.FindProperty("rootMOVIE");
		}
		#endregion

		#region GUI
		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			CoreProcess core = (CoreProcess)target;

			tab = GUILayout.Toolbar(tab, new string[] { "Produccion", "Setup", "Ayuda" });
			switch (tab)
			{
				case 0:
					MostrarProduccion(core);
					break;

				case 1:
					MostrarSetup(core);
					break;

				case 2:
					MostrarAyuda(core);
					break;
			}

			serializedObject.ApplyModifiedProperties();
		}
		#endregion

		#region Metodos GUI
		public void MostrarProduccion(CoreProcess co)
		{
			EditorGUI.indentLevel++;

			EditorGUILayout.PropertyField(dbProperty);

			EditorGUI.indentLevel--;

			if (GUILayout.Button("Generar Chart"))
			{
				co.GenerarChart();
			}

			if (GUILayout.Button("Crear Foto"))
			{
				co.CrearFoto();
			}
		}

		public void MostrarSetup(CoreProcess co)
		{
			EditorGUILayout.BeginVertical();

			EditorGUILayout.BeginHorizontal("box");
			EditorGUILayout.LabelField("Linea 1");
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.Space();

			EditorGUI.indentLevel++;
			EditorGUILayout.PropertyField(txtTemporadaProperty);
			EditorGUILayout.PropertyField(txtAnoProperty);
			EditorGUILayout.PropertyField(txtNombreProperty);
			EditorGUI.indentLevel--;

			EditorGUILayout.Space();

			EditorGUILayout.BeginHorizontal("box");
			EditorGUILayout.LabelField("Linea 2");
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.Space();

			EditorGUI.indentLevel++;
			EditorGUILayout.PropertyField(txtVersionProperty);
			EditorGUILayout.PropertyField(txtDateVersionProperty);
			EditorGUILayout.PropertyField(txtFirmaProperty);
			EditorGUI.indentLevel--;

			EditorGUILayout.Space();

			EditorGUILayout.BeginHorizontal("box");
			EditorGUILayout.LabelField("Linea 3");
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.Space();

			EditorGUI.indentLevel++;
			EditorGUILayout.PropertyField(txtMesInicioProperty);
			EditorGUILayout.PropertyField(txtAnoInicioProperty);
			EditorGUILayout.PropertyField(txtMesFinalProperty);
			EditorGUILayout.PropertyField(txtAnoFinalProperty);
			EditorGUI.indentLevel--;

			EditorGUILayout.Space();

			EditorGUILayout.BeginHorizontal("box");
			EditorGUILayout.LabelField("Linea 4");
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.Space();

			EditorGUI.indentLevel++;
			EditorGUILayout.PropertyField(txtSourceProperty);
			EditorGUI.indentLevel--;

			EditorGUILayout.Space();

			EditorGUILayout.BeginHorizontal("box");
			EditorGUILayout.LabelField("Roots");
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.Space();

			EditorGUI.indentLevel++;
			EditorGUILayout.PropertyField(rootTVProperty);
			EditorGUILayout.PropertyField(rootOVAProperty);
			EditorGUILayout.PropertyField(rootMOVIEProperty);
			EditorGUI.indentLevel--;

			EditorGUILayout.Space();

			EditorGUILayout.EndVertical();
		}

		public void MostrarAyuda(CoreProcess co)
		{
			if (GUILayout.Button("Link Github"))
			{
				Application.OpenURL("https://github.com/CodeBackDoor/AnimeChart");
			}
		}
		#endregion
	}
}