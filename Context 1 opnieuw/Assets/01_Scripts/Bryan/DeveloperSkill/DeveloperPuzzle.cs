using System;
using TMPro;
using UnityEngine;

namespace _01_Scripts.Bryan.DeveloperSkill
{
    public class DeveloperPuzzle : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _firstFloat;
        [SerializeField] private TMP_InputField _secondFloat;
        [SerializeField] private TMP_InputField _vector3;
        [SerializeField] private TMP_InputField _thirdFloat;

        private Action _onSolvedHandler;

        public bool IsSolved => CheckInput();


        private void Update()
        {
            if (IsSolved && _onSolvedHandler != null)
            {
                _onSolvedHandler.Invoke();
                _onSolvedHandler = null;
            }
        }

        public void AddOnPuzzleSolvedHandler(Action onSolvedHandler)
        {
            _onSolvedHandler = onSolvedHandler;
        }
        
        private bool CheckInput()
        {
            bool check = _firstFloat.text == "float";
            bool check1 = _secondFloat.text == "float";
            bool check2 = _thirdFloat.text == "float";
            bool check3 = _vector3.text.ToLower() == "vector3";

            return check && check1 && check2 && check3;
        }
    }
}
