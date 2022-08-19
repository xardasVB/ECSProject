using Assets.Scripts.Ecs.Components;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Ecs.Systems {
    public partial class PlayerInputSystem : SystemBase {
        
        private Vector2 _moveVector;

        protected override void OnUpdate() {
            var moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            
            Entities.ForEach((ref DirectionComponent directionComponent, in PlayerTag playerTag) => {
                ref var direction = ref directionComponent.direction;
                
                direction.x = moveVector.x;
                direction.z = moveVector.y;
                
            }).Schedule();
        }
    }
}