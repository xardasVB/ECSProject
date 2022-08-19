using Assets.Scripts.Ecs.Components;
using Unity.Entities;
using Unity.Transforms;

namespace Assets.Scripts.Ecs.Systems {
    sealed partial class MovementSystem : SystemBase {

        protected override void OnUpdate() {
            var deltaTime = Time.DeltaTime;
            
            Entities
                .ForEach((ref Translation translation, in LocalToWorld ltw,
                    in DirectionComponent directionComponent,
                    in MovableComponent movableComponent) => {
                    
                    var direction = directionComponent.direction;
                    var speed = movableComponent.speed;

                    var rawDir = (ltw.Right * direction.x) + (ltw.Forward * direction.z);
                    translation.Value += (rawDir * speed * deltaTime);
                }).Schedule();
        }
    }

    //sealed class MovementSystem : IEcsRunSystem {

    //    private readonly EcsWorld _world = null;
    //    private readonly EcsFilter<ModelComponent, MovableComponent, DirectionComponent> _movableFilter = null;
    //    
    //    public void Run() {
    //        foreach (var i in _movableFilter) {
    //            ref var modelComponent = ref _movableFilter.Get1(i);
    //            ref var movableComponent = ref _movableFilter.Get2(i);
    //            ref var directionComponent = ref _movableFilter.Get3(i);

    //            ref var transform = ref modelComponent.ModelTransform;
    //            ref var charController = ref movableComponent.CharacterController;
    //            
    //            ref var direction = ref directionComponent.Direction;
    //            ref var speed = ref movableComponent.Speed;

    //            var rawDir = (transform.right * direction.x) + (transform.forward * direction.z);
    //            charController.Move(rawDir * speed * Time.deltaTime);
    //        }
    //    }
    //}
}