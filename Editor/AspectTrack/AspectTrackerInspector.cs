﻿using UnityEditor;
using UnityEngine;

namespace HT.Framework
{
    [CustomEditor(typeof(AspectTracker))]
    public sealed class AspectTrackerInspector : HTFEditor<AspectTracker>
    {
        protected override void OnInspectorDefaultGUI()
        {
            base.OnInspectorDefaultGUI();

            GUILayout.BeginHorizontal();
            EditorGUILayout.HelpBox("Aspect Tracker, you can track code calls anywhere in the program!", MessageType.Info);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Toggle(Target.IsEnableAspectTrack, out Target.IsEnableAspectTrack, "Is Enable Track");
            GUILayout.EndHorizontal();

            if (Target.IsEnableAspectTrack)
            {
                GUILayout.BeginHorizontal();
                Toggle(Target.IsEnableIntercept, out Target.IsEnableIntercept, "Is Enable Intercept");
                GUILayout.EndHorizontal();
            }
        }

        protected override void OnInspectorRuntimeGUI()
        {
            base.OnInspectorRuntimeGUI();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Intercept Conditions: ");
            GUILayout.EndHorizontal();

            foreach (var condition in Target.InterceptConditions)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Space(20);
                GUILayout.Label(condition.Key);
                GUILayout.EndHorizontal();
            }
        }
    }
}