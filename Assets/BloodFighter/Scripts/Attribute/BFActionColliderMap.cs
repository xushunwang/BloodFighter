using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BFActionColliderMap {
	[SerializeField]
	private List<string> mKeys = new List<string>();
	[SerializeField]
	private List<BFColliderCollection> mValues = new List<BFColliderCollection>();

	public bool ContainsKey(string key)
	{
		return mKeys.Contains(key);
	}

	public BFColliderCollection Get(string key)
	{
		if(mKeys.Contains(key))
		{
			return mValues[mKeys.IndexOf(key)];
		}
		else
			return null;
	}

	public void Set(string key,BFColliderCollection value)
	{
		if(mKeys.Contains(key))
		{
			//替换
			mValues[mKeys.IndexOf(key)] = value;
		}
		else
		{
			//新加
			mKeys.Add(key);
			mValues.Add(value);
		}
	}
}
