using System;
using UnityEngine;

namespace _01_Scripts.Bryan.DeveloperSkill
{
    public class TriggerZone : MonoBehaviour
    {
        private Action _onTriggered;

        public void AddTriggerHandler(Action onTriggered)
        {
            _onTriggered = onTriggered;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            CharacterController player = other.GetComponent<CharacterController>();
                
            if (player == null)
            {
                return;
            }

            _onTriggered?.Invoke();
        }
    }
}
