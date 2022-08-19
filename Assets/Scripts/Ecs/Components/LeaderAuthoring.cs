using Assets.Scripts.OOP;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Ecs.Components {
    public class LeaderAuthoring : MonoBehaviour, IConvertGameObjectToEntity {
        public GameObject followerObject;
        
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
            var followEntity = followerObject.GetComponent<FollowEntity>();
            if (followEntity == null)
                followEntity = followerObject.AddComponent<FollowEntity>();
            followEntity.entityToFollow = entity;
        }
    }
}