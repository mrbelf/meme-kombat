using UnityEngine;

public class MovementInputManager : MonoBehaviour, IGetJumpInput, IGetXInput
{
    public bool GetJumpDown()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public bool GetJump()
    {
        return Input.GetKey(KeyCode.Space);
    }

    public float GetXInput()
    {
        var left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        var right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        if (!(left ^ right))
            return 0f;

        return left ? -1f : 1f;
    }
}
