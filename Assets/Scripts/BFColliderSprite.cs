using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BFColliderSprite : BFSprite {

	public BFColliderCollection currentColliderCollection = null;
	public Dictionary<string,BFColliderCollection> colliderMap = new Dictionary<string, BFColliderCollection>();

	public void ChangeColliderCollection(string name)
	{
		if(colliderMap.ContainsKey(name))
		{
			currentColliderCollection = colliderMap[name];
		}
		else
		{
			currentColliderCollection = null;
		}
	}
	/// <summary>
	/// 当前动画播放到第几帧，回调
	/// </summary>
	/// <param name="index">Index.</param>
	public virtual void OnSpriteAnimateAtIndex(int index)
	{
		if(currentColliderCollection != null) 
		{
			currentColliderCollection.SetColliderBoxIndex(index);
		}
	}

	public virtual void OnAnimateChange(string animateName)
	{
		ChangeColliderCollection(animateName);
	}
}
