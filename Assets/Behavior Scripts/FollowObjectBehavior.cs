using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/FollowObject")]
public class FollowObjectBehavior : FilteredFlockBehavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        List<Transform> filteredContext;
        if (filter == null)
        {
            filteredContext = context;
        }
        else
        {
            filteredContext = filter.filter(agent, context);
        }

        if (filteredContext.Count == 0 || filteredContext.Count > 1)
        {
            return Vector2.zero;
        }
        else
        {
            Vector2 target = filteredContext[0].transform.position;
            Vector2 targetOffset = target - (Vector2)agent.transform.position;
            return targetOffset;
        }
    }
}
