using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

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
            CharacterSwitch characterSwitch = other.GetComponent<CharacterSwitch>();
                
            if (player == null)
            {
                return;
            }

            if (characterSwitch.DevState == true)
            {
                _onTriggered?.Invoke();

            }
            //_onTriggered?.Invoke();
        }
    }
}
