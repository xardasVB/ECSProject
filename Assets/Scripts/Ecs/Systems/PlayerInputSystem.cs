using Assets.Scripts.Ecs.Components;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Ecs.Systems {
    public partial class PlayerInputSystem : SystemBase {
        
        private Vector2 _moveVector;
        private Vector2 _axis;

        protected override void OnUpdate() {
            _moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            _axis.x += Input.GetAxis("Mouse X");
            _axis.y -= Input.GetAxis("Mouse Y");
            
            var lookVector = _axis;
            var moveVector = _moveVector;
            
            Entities.ForEach((ref DirectionComponent directionComponent, ref LookComponent lookComponent, ref PlayerTag playerTag) => {
                ref var direction = ref directionComponent.direction;
                ref var lookDirection = ref lookComponent.direction;
                
                direction.x = moveVector.x;
                direction.z = moveVector.y;

                lookDirection = lookVector;
            }).Schedule();
        }
    }
}