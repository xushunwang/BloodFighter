using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(BFColliderCollection))]
public class BFColliderCollectionEditor : Editor {

	public override void OnInspectorGUI ()
	{
		BFColliderCollection collection = target as BFColliderCollection;

		BFSprite actor = BFTools.FindComponentInParent<BFSprite>(collection.transform);
		if(actor != null)
		{
			string[] animationNames = actor.GetAnimationNames();
			int index = BFTools.FindIndexInArray(animationNames,collection.actionName);
			int selectedIndex = EditorGUILayout.Popup("ActionName", index, animationNames);
			collection.actionName = animationNames[selectedIndex];
		}
		else
		{
			Debug.LogError("BFColliderCollection must be the child of BFSprite component!");
		}

		NGUIEditorTools.BeginContents();
		if(NGUIEditorTools.DrawHeader("Colliders"))
		{
			BFCollider[] childColliders = collection.GetComponentsInChildren<BFCollider>(true);
			if(childColliders.Length > 0)
			{
				BFTools.SortTransformByName(childColliders);
				collection.colliders = childColliders;
				for(int i = 0; i < childColliders.Length; i++)
				{
					EditorGUILayout.ObjectField("collider" + i, childColliders[i], typeof(BFCollider), true);
				}
			}
			else
			{
				EditorGUILayout.LabelField("No BFCollider in children!");
			}

		}

		//GUILayout.Toggle(true, "Colliders", "dragtab", GUILayout.MinWidth(20f));
		NGUIEditorTools.EndContents();

		Debug.Log("Editor Code : " + this.GetHashCode());
	}
}
