using UnityEngine;

public class MovementInputManager : MonoBehaviour, IGetJumpInput, IGetXInput, IGetPunchInput
{
    public bool GetJumpDown()
    {
        return Input.GetKeyDown(KeyCode.C);
    }

    public bool GetJump()
    {
        return Input.GetKey(KeyCode.C);
    }

    public float GetXInput()
    {
        var left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        var right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        if (!(left ^ right))
            return 0f;

        return left ? -1f : 1f;
    }

    public bool GetPunchDown()
    {
        return Input.GetKeyDown(KeyCode.X);
    }

    public bool GetPunch()
    {
        return Input.GetKey(KeyCode.X);
    }
}
