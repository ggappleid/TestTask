using UnityEngine;
using System.Collections;

public class SelectedItem : MonoBehaviour
{
	private Item currentItem;

	void OnDrop(GameObject go)
	{
		var item = go.GetComponent<Item>();

		if (item == null || go.transform.parent.name == "Holder")
		{
			// We dragged non-item GameObject or non-dragged item
			return;
		}

		// If we want to add or replace current Item
		if (currentItem != item)
		{
			// Replacing current item with new
			if (currentItem != null)
			{
				// Restore old hierarchy
				currentItem.transform.SetParent(currentItem.Parent);

				// Reset old position if possible
				if (currentItem.Parent != null)
				{
					var grid = currentItem.Parent.GetComponent<UIGrid>();
					grid.Reposition();
				}
			}

			currentItem = item;
		}
	}
}
