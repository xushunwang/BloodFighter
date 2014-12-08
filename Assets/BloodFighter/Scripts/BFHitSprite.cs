using UnityEngine;
using System.Collections;

public class BFHitSprite : BFColliderSprite {
	[HideInInspector]
	public BFColliderCollection currentHitCollection = null;

	public BFActionColliderMap hitMap = new BFActionColliderMap();
	
	public void ChangeHitCollection(string name)
	{
		if(hitMap.ContainsKey(name))
		{
			currentHitCollection = hitMap.Get(name);
		}
		else
		{
			currentHitCollection = null;
		}
	}

	public override void OnSpriteAnimateAtIndex (int index)
	{
		base.OnSpriteAnimateAtIndex(index);
//		if(currentHitCollection != null) 
//		{
//			currentHitCollection.SetColliderBoxIndex(index);
//		}
	}

	public override void OnAnimationChange(string preName,string nowAnimateName)
	{
		base.OnAnimationChange(preName,nowAnimateName);
		ChangeHitCollection(nowAnimateName);
	}
}
