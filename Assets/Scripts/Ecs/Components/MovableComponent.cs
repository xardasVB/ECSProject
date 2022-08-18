using UnityEngine;

namespace Assets.Scripts.Ecs.Components {
    internal struct MovableComponent {
        public CharacterController CharacterController;
        public float Speed;
    }
}