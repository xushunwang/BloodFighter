using UnityEngine;
using System.Collections;

public class BFCollider : MonoBehaviour {
	private Collider2D[] mColliders;
	/// <summary>
	/// 碰撞的y轴距离
	/// </summary>
	public float yDistance;
	void Awake()
	{
		OnAwake();
	}
	
	void Start()
	{
		OnStart();
	}
	
	public virtual void OnAwake()
	{
		mColliders = GetComponents<Collider2D>();
		IsEnable = false;
	}
	public virtual void OnStart()
	{
		
	}
	
	private bool mIsEnable = false;
	public bool IsEnable
	{
		get
		{
			return mIsEnable;
		}
		set
		{
			if(mIsEnable != value)
			{
				mIsEnable = value;
				gameObject.SetActive(value);
			}
		}
	}
}
