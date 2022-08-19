using Assets.Scripts.Ecs.Components;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Assets.Scripts.Ecs.Systems {
    sealed partial class LookSystem : SystemBase {
        
        protected override void OnUpdate() {
            var deltaTime = Time.DeltaTime;

            Entities
                .ForEach((ref Translation translation, ref Rotation rotation,  in LocalToWorld ltw, in LookComponent lookComponent) => {
                    Vector3 axis = lookComponent.direction;

                    var rotateX = Quaternion.AngleAxis(axis.x, Vector3.up * deltaTime * lookComponent.sensitivity);
                    var rotateY = Quaternion.AngleAxis(axis.y, Vector3.right * deltaTime * lookComponent.sensitivity);

                    rotation.Value = rotateX;

                }).Schedule();
        }
    }
}