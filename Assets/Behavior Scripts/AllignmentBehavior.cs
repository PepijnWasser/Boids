using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Allignment")]
public class AllignmentBehavior : FilteredFlockBehavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (context.Count == 0)
        {
            return agent.transform.up;
        }

        Vector2 allignmentMove = Vector2.zero;
        List<Transform> filteredContext = (filter == null) ? context : filter.filter(agent, context);

        foreach (Transform item in filteredContext)       
        {
            allignmentMove += (Vector2)item.transform.up;
        }
        allignmentMove /= context.Count;

        return allignmentMove;
    }
}
