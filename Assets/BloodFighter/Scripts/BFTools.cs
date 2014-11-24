using UnityEngine;
using System.Collections;

public class BFTools  {

	/// <summary>
	/// 循环遍历父节点找对应的脚本
	/// </summary>
	public static T FindComponentInParent<T>(Transform t) where T : Component
	{
		Transform parent = t;
		while(parent != null)
		{
			T script = parent.GetComponent<T>();
			if(script != null)
				return script;

			parent = parent.parent;
		}
		return null;
	}

	/// <summary>
	/// 相当于List中的indexOf方法
	/// </summary>
	public static int FindIndexInArray(System.Object[] array,System.Object obj)
	{
		int index = 0;
		for(int i = 0; i < array.Length; i++)
		{
			if(array[i].Equals(obj))
			{
				index = i;
				break;
			}
		}

		return index;
	}
}
