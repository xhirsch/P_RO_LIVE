using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls controls;
    public CharacterController controller;

    private void Awake() {
        controls = new PlayerControls();
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }

    private void Update() {
        Vector2 move = controls.Gameplay.Move.ReadValue<Vector2>();
        controller.Move(move * Time.deltaTime * 3.14f);
        Debug.Log(controls.Gameplay.Move.ReadValue<Vector2>());
    }
}
