using UnityEngine;

namespace GenericForBeginners
{
    public class PlayerController : MonoBehaviour
    {
        public int PlayerHealth { get; set; }

        public void PlayerSpecialPower()
        {
            Debug.Log("Player special power");
        }
    }
}