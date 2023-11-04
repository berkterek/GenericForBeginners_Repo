using UnityEngine;

namespace GenericForBeginners
{
    public class DynamicEnemyController : MonoBehaviour
    {
        public int EnemyHealth { get; set; }
        public int EnemyDamage { get; set; }

        public void PlayerSpecialPowerDefence()
        {
            Debug.Log("Enemy special power defence");
        }
    }
}