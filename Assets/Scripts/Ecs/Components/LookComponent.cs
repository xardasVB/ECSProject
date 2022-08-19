using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Ecs.Components {
    [GenerateAuthoringComponent]
    public struct LookComponent : IComponentData {
        public Vector2 direction;
        public float sensitivity;
    }
}