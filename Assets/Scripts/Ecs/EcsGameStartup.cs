using Leopotam.Ecs;
using UnityEngine;

namespace Assets.Scripts.Ecs {
    public sealed class EcsGameStartup : MonoBehaviour {
        private EcsWorld _world;
        private EcsSystems _systems;

        private void Start() {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

            AddInjections();
            AddOneFrames();
            AddSystems();
            
            //_systems.ConvertScene();
            _systems.Init();
        }

        private void Update() {
            _systems.Run();
        }

        private void AddInjections() {
            
        }
        
        private void AddSystems() {
            
        }
        
        private void AddOneFrames() {
            
        }

        private void OnDestroy() {
            if (_systems == null) return;
            
            _systems.Destroy();
            _systems = null;
            _world.Destroy();
            _world = null;
        }
    }
}
