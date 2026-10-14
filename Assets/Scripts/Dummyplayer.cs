using UnityEngine;
using UnityEngine.InputSystem;

public class DummyPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Keyboard.current.wKey.isPressed) move.z += 1f;
        if (Keyboard.current.sKey.isPressed) move.z -= 1f;
        if (Keyboard.current.aKey.isPressed) move.x -= 1f;
        if (Keyboard.current.dKey.isPressed) move.x += 1f;

        transform.Translate(move.normalized * moveSpeed * Time.deltaTime, Space.World);
    }
}