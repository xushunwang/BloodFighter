using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(BFHitSprite))]
public class BFHitSpriteEditor : BFColliderSpriteEditor {
	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
		BFHitSprite sprite = target as BFHitSprite;
		string[] actionNames =  sprite.GetAnimationNames();
		//collider 集合
		NGUIEditorTools.BeginContents();
		if(NGUIEditorTools.DrawHeader("Hit Actions"))
		{
			if(actionNames.Length > 0)
			{
				//找这个节点下所有的collider组件
				List<BFColliderCollection> childCollections = BFTools.GetComponentInChildren<BFColliderCollection>(sprite.transform);

				for(int i = 0; i < actionNames.Length; i++)
				{
					string key = actionNames[i];
					BFColliderCollection collection = null;
					
					for(int j = 0 ; j < childCollections.Count ;j++)
					{
						if(key.Equals(childCollections[j].actionName) && childCollections[j].type == BFColliderCollectionType.HitBox)
						{
							collection = childCollections[j];
							break;
						}
					}

					sprite.hitMap.Set(key ,(BFColliderCollection)EditorGUILayout.ObjectField(key, collection, typeof(BFColliderCollection), true));
				}
			}
			else
			{
				EditorGUILayout.LabelField("No actions in the component!");
			}
			
		}
		NGUIEditorTools.EndContents();
	}
}
