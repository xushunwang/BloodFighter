using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BFHitSprite : BFColliderSprite {

	public BFColliderCollection currentHitCollection = null;
	public Dictionary<string,BFColliderCollection> hitMap = new Dictionary<string, BFColliderCollection>();
	
	public void ChangeHitCollection(string name)
	{
		if(hitMap.ContainsKey(name))
		{
			currentHitCollection = hitMap[name];
		}
		else
		{
			currentHitCollection = null;
		}
	}

	public override void OnSpriteAnimateAtIndex (int index)
	{
		base.OnSpriteAnimateAtIndex(index);
		if(currentHitCollection != null) 
		{
			currentHitCollection.SetColliderBoxIndex(index);
		}
	}

	public override void OnAnimateChange (string animateName)
	{
		base.OnAnimateChange(animateName);
		ChangeHitCollection(animateName);
	}
}
