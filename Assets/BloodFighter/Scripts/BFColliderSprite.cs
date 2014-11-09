using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BFColliderSprite : BFSprite {
	[HideInInspector]
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

	public override void OnAnimationChange(string preName,string nowAnimateName)
	{
		ChangeColliderCollection(nowAnimateName);
	}

	/// <summary>
	/// 给动画回调用的方法，用virtual的标记他不识别
	/// </summary>
	/// <param name="index">Index.</param>
	public void OnSpriteFrameAtIndex(int index)
	{
		OnSpriteAnimateAtIndex(index);
	}

}
