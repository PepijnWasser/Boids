using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Filter/tag")]
public class TagFilter : ContextFilter
{
    public string tag;

    public override List<Transform> filter(FlockAgent agent, List<Transform> original)
    {
        List<Transform> filtered = new List<Transform>();
        foreach (Transform item in original)
        {
            if (item.gameObject.tag == tag)
            {
                filtered.Add(item);
            }
        }
        return filtered;
    }
}
