﻿using Unity.Entities;
using Unity.Mathematics;

[System.Serializable]
[GenerateAuthoringComponent]
public struct BoidSettingsComponent : IComponentData
{
    public float MoveSpeed;
    public float MaxMoveSpeed;
    public float LookSpeed;

    public float BoidDetectRadius;
    public float BoidDetectFOV;

    public float CohesionWeight;
    public float AlignmentWeight;
    public float SeparationWeight;

    public float ObstacleAvoidWeight;
    public float ObstacleViewDst;

    public float FiringViewDst;
    public float FiringFOV;
    public float LineOfSightWeight;

    public float3 MapCentre;
    public float MapRadius;
    public float MapRadiusWeight;
}