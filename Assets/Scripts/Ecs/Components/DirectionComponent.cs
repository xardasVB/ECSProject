using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Ecs.Components {
    [GenerateAuthoringComponent]
    public struct DirectionComponent : IComponentData {
        public Vector3 direction;
    }
}