using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;

[GenerateAuthoringComponent]
public struct ObjectData : IComponentData
{
    public float3 Position;
    public float3 Scale;
    public float3 target;
    public Quaternion rotatio;
    public float speed;
    public float rotationSpeed;
}


