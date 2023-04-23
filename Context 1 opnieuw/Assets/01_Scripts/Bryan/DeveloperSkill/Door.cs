using UnityEngine;

namespace _01_Scripts.Bryan.DeveloperSkill
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void Open()
        {
            _animator.Play("Open");
        }
        
        public void Close()
        {
            _animator.Play("Close");
        }
    }
}