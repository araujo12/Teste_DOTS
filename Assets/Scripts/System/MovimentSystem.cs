using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;
using System.Threading;

public class MovimentSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltaTime = Time.DeltaTime;
        

        Entities.ForEach((ref Translation translation, in ObjectData objectData) =>
        {
            translation.Value.z += objectData.speed * deltaTime;

        }).Run();

        return default;
    }
}


