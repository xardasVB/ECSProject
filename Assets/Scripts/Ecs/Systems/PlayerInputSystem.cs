using Assets.Scripts.Ecs.Components;
using Assets.Scripts.Ecs.Tags;
using Leopotam.Ecs;

namespace Assets.Scripts.Ecs.Systems {
    sealed class PlayerInputSystem : IEcsRunSystem {
        
        private readonly EcsFilter<PlayerTag, DirectionComponent> _directionFilter = null;

        public void Run() {
            foreach (var i in _directionFilter) {
                ref PlayerTag playerTag = ref _directionFilter.Get1(i);
                ref DirectionComponent directionComponent = ref _directionFilter.Get2(i);
            }
        }
    }
}