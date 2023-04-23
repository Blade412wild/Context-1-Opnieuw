using System.Collections;
using System.Collections.Generic;
using _01_Scripts.Bryan.DeveloperSkill;
using UnityEngine;

public class TestTirgger : MonoBehaviour
{
    [SerializeField] private TriggerZone _triggerZone;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _triggerZone.AddTriggerHandler(OnTriggered);
    }

    private void OnTriggered()
    {
        print("hoi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
