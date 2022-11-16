using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI_Inputs : MonoBehaviour
{
    [SerializeField]
    GameObject UI;
    private Shooter_Game_IS _inputUIActionShooter;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
        _inputUIActionShooter = PlayerController._inputActionShooter;

        _inputUIActionShooter.Game.Enable();
        _inputUIActionShooter.UI.Back2Game.Disable();


        _inputUIActionShooter.Game.Pause.performed += ctx => OnPause();
        _inputUIActionShooter.Game.Pause.canceled -= ctx => OnPause();

        _inputUIActionShooter.UI.Back2Game.performed += ctx => OnStart();
        _inputUIActionShooter.UI.Back2Game.canceled -= ctx => OnStart();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPause()
    {
        _inputUIActionShooter.Game.Disable();
        _inputUIActionShooter.UI.Enable();
        Debug.Log("pause");
        UI.SetActive(true);
    }
    public void OnStart()
    {
        _inputUIActionShooter.Game.Enable();
        _inputUIActionShooter.UI.Disable();
        UI.SetActive(false);
    }
}
