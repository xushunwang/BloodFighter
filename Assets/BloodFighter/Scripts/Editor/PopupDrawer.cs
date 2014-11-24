using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(PopupAttribute))]
public class PopupDrawer : PropertyDrawer {

	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		PopupAttribute attr = (PopupAttribute)attribute;
		
		int index = 0;
		for(int i = 0 ; i < attr.list.Length ;i++)
		{
			if(attr.list[i].Equals(property.stringValue))
			{
				index = i;
				break;
			}
		}
		
		int selected = EditorGUI.Popup(position,index,attr.list);
		property.stringValue = attr.list[selected];
	}
}
