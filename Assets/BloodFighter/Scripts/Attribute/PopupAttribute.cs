using UnityEngine;
using System.Collections;

public class PopupAttribute : PropertyAttribute
{
	public readonly string[] list;
	public PopupAttribute(params string[] list)
	{
		this.list = list;
	}
}
