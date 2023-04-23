using StarterAssets.ThirdPersonController.Scripts;
using UnityEngine;

namespace _01_Scripts.Bryan.DesignerSkill
{
    public class SkillUIManager : MonoBehaviour
    {
        [SerializeField] private RowValue _speedRow;
        [SerializeField] private RowValue _jumpRow;
        [SerializeField] private RowValue _gravityRow;

        private ThirdPersonController _player;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void ConfigurePlayer()
        {
            _speedRow.Configure("Speed", OnClickIncreaseSpeed, OnClickDecreaseSpeed);
            _jumpRow.Configure("Jump", OnClickIncreaseJump, OnClickDecreaseJump);

            _gravityRow.Configure("Gravity", OnClickIncreaseGravity, OnClickDecreaseGravity);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        /// SPEED SKILL
        private void OnClickDecreaseSpeed()
        {
            _player.MoveSpeed -= 1;
            _player.MoveSpeed = Mathf.Clamp(_player.MoveSpeed, 1f, 10f);
            _speedRow.ConfigureLabel("Speed: " + _player.MoveSpeed);
        }

        private void OnClickIncreaseSpeed()
        {
            _player.MoveSpeed += 1;
            _player.MoveSpeed = Mathf.Clamp(_player.MoveSpeed, 1f, 10f);
            _speedRow.ConfigureLabel("Speed: " + _player.MoveSpeed);
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////
        /// JUMPHEIGHT SKILL
        private void OnClickDecreaseJump()
        {
            _player.JumpHeight -= 1;
            _player.JumpHeight = Mathf.Clamp(_player.JumpHeight, 1f, 10f);
            _jumpRow.ConfigureLabel("JumpHeight: " + _player.JumpHeight);
        }

        private void OnClickIncreaseJump()
        {
            _player.JumpHeight += 1;
            _player.JumpHeight = Mathf.Clamp(_player.JumpHeight, 1f, 10f);
            _jumpRow.ConfigureLabel("JumpHeight: " + _player.JumpHeight);
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////
        /// GRAVITY SKILL
        private void OnClickDecreaseGravity()
        {
            _player.Gravity -= 1;
            _player.Gravity = Mathf.Clamp(_player.Gravity, -20f, -1f);
            _gravityRow.ConfigureLabel("Gravity: " + _player.Gravity);
        }

        private void OnClickIncreaseGravity()
        {
            _player.Gravity += 1;
            _player.Gravity = Mathf.Clamp(_player.Gravity, -20f, -1f);
            _gravityRow.ConfigureLabel("Gravity: " + _player.Gravity);
        }

        public void SetPlayer(ThirdPersonController player)
        {
            _player = player;
            ConfigurePlayer();   
        }
    }
}
