using UnityEngine;
using Mirror;

public class MovementInputManager : NetworkBehaviour, IGetJumpInput, IGetXInput, IGetPunchInput
{
    public bool GetJumpDown()
    {
        return Input.GetKeyDown(KeyCode.C) && isLocalPlayer;
    }

    public bool GetJump()
    {
        return Input.GetKey(KeyCode.C) && isLocalPlayer;
    }

    public float GetXInput()
    {
        if (!isLocalPlayer)
            return 0;

        var left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        var right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        if (!(left ^ right))
            return 0f;

        return left ? -1f : 1f;
    }

    public bool GetPunchDown()
    {
        return Input.GetKeyDown(KeyCode.X) && isLocalPlayer;
    }

    public bool GetPunch()
    {
        return Input.GetKey(KeyCode.X) && isLocalPlayer;
    }
}
