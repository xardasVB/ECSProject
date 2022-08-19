using System;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Ecs.Components {
    [GenerateAuthoringComponent]
    public struct MovableComponent : IComponentData {
        public float speed;
    }
}