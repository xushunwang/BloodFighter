using UnityEngine;
using UnityEditor;

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
			Debug.LogError("BFColliderCollection必须绑定在BFSprite组件节点下");
		}

		//NGUIEditorTools.BeginContents();
		if(NGUIEditorTools.DrawHeader("Colliders"))
		{
			for(int i = 0; i < 3; i++)
			{
				//EditorGUILayout.LabelField("collider" + i);
				EditorGUILayout.ObjectField("collider" + i, null, typeof(BFCollider), true);
			}
		}

		//GUILayout.Toggle(true, "Colliders", "dragtab", GUILayout.MinWidth(20f));
		//NGUIEditorTools.EndContents();
	}
}
