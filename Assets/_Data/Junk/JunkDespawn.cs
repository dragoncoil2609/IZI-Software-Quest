using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 25f; // Default distance limit for despawning
    }
}

