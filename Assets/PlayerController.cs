using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

    private void Awake() {

        playerControls = new PlayerControls();

    }

    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    private void Start() {
        
    }

    private void Update() {
    Vector2 move = playerControls.Gameplay.Move.ReadValue<Vector2>();
    // Debug.Log(move);
    float grow = playerControls.Gameplay.Grow.ReadValue<float>();
    Debug.Log(grow);
    }

}
