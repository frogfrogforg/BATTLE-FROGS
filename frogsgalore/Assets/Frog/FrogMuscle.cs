using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple hinge muscle for jumping around.
// Call Set(bool onoff) to expand/contract the muscle.

public class FrogMuscle : MonoBehaviour
{
    public float restAngle = 0f;
    public float jumpAngle = 0f;

    public float jumpForce = 10f;
    public float restForce = 1f;

    private HingeJoint _hinge;

    // Start is called before the first frame update
    void Start()
    {
        _hinge = GetComponent<HingeJoint>();
    }

    // Call with true/false to activate muscle towards resting/jump respectively.
    public void Set(bool isJump) {
        if (isJump) {
            SetHinge(jumpForce, jumpAngle);
        } else {
            SetHinge(restForce, restAngle);
        }
    }

    private void SetHinge(float springForce, float targetAngle)
    {     
        // (Helper method since we can't set JointSpring properties directly)
        JointSpring spring = _hinge.spring;
        spring.spring = springForce;
        spring.targetPosition = targetAngle;
        _hinge.spring = spring;
    }
}
