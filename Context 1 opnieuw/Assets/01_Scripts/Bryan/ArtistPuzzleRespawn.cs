using System;
using StarterAssets.ThirdPersonController.Scripts;
using UnityEngine;

namespace _01_Scripts.Bryan
{
    public class ArtistPuzzleRespawn : MonoBehaviour
    {
        [SerializeField] private Transform _respawnPoint;
        
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Player entered area which kills him");
            
            var player = other.GetComponent<ThirdPersonController>();
            var characterController = other.GetComponent<CharacterController>();

            if (player == null)
            {
                Debug.Log("Player is null");
                return;
            }
            
            if (player)
            {
                Debug.Log("player should be respawned");
                characterController.enabled = false;
                player.transform.position = _respawnPoint.position;
                characterController.enabled = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            
            Debug.Log("Respawned succesfully");
        }
    }
}
