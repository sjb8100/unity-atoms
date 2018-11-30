using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Event", fileName = "GameObjectEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class GameObjectEvent : GameEvent<GameObject> { }
}