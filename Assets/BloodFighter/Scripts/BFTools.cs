using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
	/// 循环遍历子节点找对应的脚本
	/// </summary>
	public static List<T> GetComponentInChildren<T>(Transform t) where T : Component
	{
		List<T> list = new List<T>();

		FindComponentInChildren(t,list);

		return list;
	}
	/// <summary>
	/// 遍历自己循环找对应脚本
	/// </summary>
	static void FindComponentInChildren<T>(Transform t,List<T> list) where T : Component
	{
		T comp = t.GetComponent<T>();
		if(comp != null)
			list.Add(comp);

		foreach(Transform trans in t)
		{
			FindComponentInChildren<T>(trans,list);
		}
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

	/// <summary>
	/// 根据transform的名字排序
	/// </summary>
	public static int SortTransformByName(Transform a,Transform b)
	{
		return string.Compare(a.name, b.name);
	}

	/// <summary>
	/// transform数组按照名字从小到大排序
	/// </summary>
	public static void SortTransformByName(Component[] comps)
	{
		for(int i = 0 ; i < comps.Length - 1; i++)
		{
			for(int j = 0 ; j < comps.Length - i - 1 ; j++)
			{
				if(string.Compare( comps[j].name,comps[j + 1].name) > 0)
				{
					Component temp = comps[j];
					comps[j] = comps[j + 1];
					comps[j + 1] = temp;
				}
			}
		}
	}
}
