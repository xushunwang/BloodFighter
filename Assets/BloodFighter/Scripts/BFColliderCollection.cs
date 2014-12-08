using UnityEngine;
using System.Collections;

public enum BFColliderCollectionType
{
	HitBox,
	ColliderBox
}

public class BFColliderCollection : MonoBehaviour {
	public BFColliderCollectionType type;
	public string actionName;
	public BFCollider[] colliders;

//	/// <summary>
//	/// 当前被碰撞盒子的in的值
//	/// </summary>
//	private int mColliderBoxIndex = 0;
//	public int GetColliderBoxIndex()
//	{
//		return mColliderBoxIndex;
//	}
//	/// <summary>
//	/// 切换被碰撞盒子
//	/// </summary>
//	public void SetColliderBoxIndex(int index)
//	{
//		if(mColliderBoxIndex != index)
//		{
//			colliders[mColliderBoxIndex].IsEnable = false;
//			mColliderBoxIndex = index;
//			colliders[index].IsEnable = true;
//			//do other things
//		}
//	}
}
