using Assets.Scripts.Ecs.Components;
using Leopotam.Ecs;

namespace Assets.Scripts.Ecs.Systems {
    sealed class MovementSystem : IEcsRunSystem {

        private readonly EcsWorld _world = null;
        private readonly EcsFilter<MovableComponent, DirectionComponent> _movableFilter = null;
        
        public void Run() {
            
        }
    }
}