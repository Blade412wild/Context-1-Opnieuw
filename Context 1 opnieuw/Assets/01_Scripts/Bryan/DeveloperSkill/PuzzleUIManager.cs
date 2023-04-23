using System;
using StarterAssets.ThirdPersonController.Scripts;
using UnityEngine;

namespace _01_Scripts.Bryan.DeveloperSkill
{
    public class PuzzleUIManager : MonoBehaviour
    {
        [SerializeField] private DeveloperPuzzle _developerPuzzle;
        [SerializeField] private TriggerZone _triggerZone;
        [SerializeField] private Door _door;
        [SerializeField] private ThirdPersonController _thirdPersonController;

        private void Start()
        {
            _triggerZone.AddTriggerHandler(OnTriggered);
            _developerPuzzle.AddOnPuzzleSolvedHandler(OnSolvedHandler);
        }
    
        //When the puzzle is solved
        private void OnSolvedHandler()
        {
            _thirdPersonController.MayMove = true;
            _developerPuzzle.gameObject.SetActive(false);
            _door.Open();
        }

        //OnTriggerzone triggered
        private void OnTriggered()
        {
            if (_developerPuzzle.IsSolved)
            {
                return;
            }

            _thirdPersonController.MayMove = false;
            _developerPuzzle.gameObject.SetActive(true);
        }

        private void Update()
        {
            Debug.Log(_thirdPersonController.MayMove);
        }
    }
}