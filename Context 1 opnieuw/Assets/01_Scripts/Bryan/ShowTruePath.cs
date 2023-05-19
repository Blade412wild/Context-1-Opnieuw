using System;
using StarterAssets.ThirdPersonController.Scripts;
using UnityEngine;

namespace _01_Scripts.Bryan
{
    public class ShowTruePath : MonoBehaviour
    {
        [Header("Drag the NEXT truepath objects in these fields!")]
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private MeshFilter _meshFilter;

        private CharacterSwitch _characterSwitch;

        private void Start()
        {
            _meshRenderer.gameObject.SetActive(false);
            _meshFilter.gameObject.SetActive(false);
            _characterSwitch = gameObject.GetComponent<CharacterSwitch>();
        }

        private void OnTriggerEnter(Collider other)
        {
            var player = other.GetComponent<ThirdPersonController>();
            var artCheck = other.GetComponent<CharacterSwitch>().ArtState;

            if (player == null)
            {
                return;
            }

            if (artCheck == false)
            {
                return;
            }
            
            _meshRenderer.gameObject.SetActive(true);
            _meshFilter.gameObject.SetActive(true);
        }
    }
}