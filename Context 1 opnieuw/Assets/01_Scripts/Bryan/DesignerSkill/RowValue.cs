using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _01_Scripts.Bryan.DesignerSkill
{
    public class RowValue : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _label;
        [SerializeField] private Button _buttonIncrease;
        [SerializeField] private Button _buttonDecrease;

        public void ConfigureLabel(string labelName)
        {
            _label.text = labelName;
        }
        
        public void Configure(string label, UnityAction onClickIncrease, UnityAction onClickDecrease)
        {
            _buttonIncrease.onClick.RemoveAllListeners();
            _buttonDecrease.onClick.RemoveAllListeners();
            
            _label.text = label;
            _buttonIncrease.onClick.AddListener(onClickIncrease);
            _buttonDecrease.onClick.AddListener(onClickDecrease);
        }
    }
}