using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
	public Transform Parent;

	void Start()
	{
		Parent = this.transform.parent;
	}
}
