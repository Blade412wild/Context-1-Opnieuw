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

        private void Start()
        {
            _meshRenderer.gameObject.SetActive(false);
            _meshFilter.gameObject.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            var player = other.GetComponent<ThirdPersonController>();

            if (player == null)
            {
                return;
            }
            
            _meshRenderer.gameObject.SetActive(true);
            _meshFilter.gameObject.SetActive(true);
        }
    }
}