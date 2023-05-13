using StarterAssets.ThirdPersonController.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public GameObject Player;
    private ThirdPersonController ThirdPersonController;
    // Start is called before the first frame update
    void Start()
    {
        ThirdPersonController = Player.GetComponent<ThirdPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ThirdPersonController.MayMove = false;
            Debug.Log("C");
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            ThirdPersonController.MayMove = true;
        }
    }
}
