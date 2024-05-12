using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    public Transform player;
    private Camera _camera;


    private void Awake()
    {
        _camera = Camera.main;
    }

    private void LateUpdate()
    {
        if (_camera != null)
        {
            Vector3 position = player.position;
           _camera.transform.position = new Vector3(position.x, position.y, -10);
        }
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Debug.Log(newAim);
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }
}