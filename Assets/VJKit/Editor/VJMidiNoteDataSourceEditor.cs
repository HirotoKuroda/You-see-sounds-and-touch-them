﻿/* 
 * fuZe vjkit
 * 
 * Copyright (C) 2013 Unity Technologies Japan, G.K.
 * 
 * Permission is hereby granted, free of charge, to any 
 * person obtaining a copy of this software and associated 
 * documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation 
 * the rights to use, copy, modify, merge, publish, distribute, 
 * sublicense, and/or sell copies of the Software, and to permit 
 * persons to whom the Software is furnished to do so, subject 
 * to the following conditions: The above copyright notice and 
 * this permission notice shall be included in all copies or 
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
 * OTHER DEALINGS IN THE SOFTWARE.
 * 
 * Special Thanks:
 * The original software design and architecture of fuZe vjkit 
 * is inspired by Visualizer Studio, created by Altered Reality 
 * Entertainment LLC.
 */
using UnityEngine;
using System.Collections;
using UnityEditor;
using System;
using System.Collections.Generic;

[CustomEditor(typeof(VJMidiNoteDataSource))]
[CanEditMultipleObjects]
public class VJMidiNoteDataSourceEditor : VJAbstractDataSourceEditor 
{
	public SerializedProperty lowerNoteProperty;
	public SerializedProperty upperNoteProperty;

	void OnEnable() {
		lowerNoteProperty = serializedObject.FindProperty("lowerNote");
		upperNoteProperty = serializedObject.FindProperty("upperNote");
	}

    public override void OnInspectorGUI()
    {
		base.OnInspectorGUI();

		serializedObject.Update();

		Rect r = GUILayoutUtility.GetLastRect();
		r.y -= 6;

		float lowerNote = (float)lowerNoteProperty.intValue;
		float upperNote = (float)upperNoteProperty.intValue;
		EditorGUI.MinMaxSlider(new GUIContent("Range[" +lowerNote +":"+ upperNote + "]"),  r, ref lowerNote, ref upperNote, 0,  127 ); 
		lowerNoteProperty.intValue = (int)lowerNote;
		upperNoteProperty.intValue = (int)upperNote;

		serializedObject.ApplyModifiedProperties();
	}
}
