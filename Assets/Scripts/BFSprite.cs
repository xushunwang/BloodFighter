using UnityEngine;
using System.Collections;

public class BFSprite : BFBattleItem {
	public Animator animator;

	public virtual string[] GetAnimationNames()
	{
		return new string[]{};
	}

	private string mCurrentAnimationName = null;
	public string CurrentAnimationName
	{
		get
		{
			return mCurrentAnimationName;
		}
		set
		{
			if(!string.Equals(mCurrentAnimationName,value))
			{
				string preName = mCurrentAnimationName;
				mCurrentAnimationName = value;
				OnAnimationChange(preName,value);
			}
		}
	}

	public virtual void OnAnimationChange(string preName,string nowAnimateName)
	{

	}

	public override void Update ()
	{
		base.Update();

		//获得当前状态播放的动画名字
		if(animator != null)
		{
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
			string[] allAnimationNames = GetAnimationNames();
			for(int i = 0 ; i < allAnimationNames.Length;i++)
			{
				if(stateInfo.IsName(allAnimationNames[i]))
				{
					CurrentAnimationName = allAnimationNames[i];
					break;
				}
			}
		}
	}
}
