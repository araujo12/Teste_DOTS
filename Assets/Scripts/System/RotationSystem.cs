using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;
using Unity.Mathematics;
using Unity.Transforms;

public class RotationSystem : JobComponentSystem
{

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Rotation rotation, in ObjectData objectData) =>
        {
            rotation.Value = math.mul(rotation.Value, quaternion.RotateY(math.radians(objectData.rotationSpeed * deltaTime)));
        }).Run();

        return default;

    }
}
