using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BFActor))]
public class BFActorEditor : BFHitSpriteEditor {

	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
	}
}
