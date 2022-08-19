using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Assets.Scripts.OOP {
    public class FollowEntity : MonoBehaviour {

        public Entity entityToFollow;
        public float3 offset;

        private EntityManager _manager;
        
        private void Awake() {
            _manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        }

        private void LateUpdate() {
            Translation entPos = _manager.GetComponentData<Translation>(entityToFollow);
            transform.position = entPos.Value + offset;
        }
        
    }
}