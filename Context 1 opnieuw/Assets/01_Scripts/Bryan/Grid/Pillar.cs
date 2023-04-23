using System;
using _01_Scripts.Bryan.ArtistSkill;
using _01_Scripts.Bryan.DeveloperSkill;
using UnityEngine;

namespace _01_Scripts.Bryan.Grid
{
    public class Pillar : MonoBehaviour
    {
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private MeshFilter _meshFilter;
        
        private MeshSwapModel _model;


        public int Index;

        private Action<int> _onPillarActivatedHandler;

        private void OnTriggerEnter(Collider other)
        {
            _onPillarActivatedHandler?.Invoke(Index);
        }

        public void AddPillarActivatedHandler(Action<int> onPillarActivatedHandler)
        {
            _onPillarActivatedHandler = onPillarActivatedHandler;
        }
        
        //Set the model for this pillar
        public void UpdateModel(MeshSwapModel model)
        {
            _model = model;
        }

        //Actual swap of the model
        public void SwapModel()
        {
            _meshRenderer.material = _model.Material;
            _meshFilter.mesh = _model.Mesh;
        }
    }
}