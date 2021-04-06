﻿using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct BoidComponent : IComponentData
{
    public uint GroupID;
    public float HP;

    public Entity SettingsEntity;
    public float3 MoveForce;
    public float3 TargetUp;

    public float3 LineOfSightForce;

    public float NextAllowShootTime;
    public float3 TrailOffset;
}