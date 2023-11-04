using Unity.Mathematics;
using UnityEngine;

namespace GenericForBeginners
{
    public class ThirdExample1 : BasePrefabGeneric<PlayerController>
    {
        
    }

    public abstract class BasePrefabGeneric<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] protected T _prefab;

        [ContextMenu(nameof(Spawn))]
        public void Spawn()
        {
            Instantiate(_prefab, Vector3.zero, quaternion.identity);
        }
    }
}