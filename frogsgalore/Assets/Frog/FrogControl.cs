using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogControl : MonoBehaviour
{
    public float turnTorque = 3f;
    public Rigidbody torso;

    private FrogMuscle[] _muscles;

    // Start is called before the first frame update
    void Start()
    {
      _muscles = GetComponentsInChildren<FrogMuscle>();
    }

    // Update is called once per frame
    void Update()
    {
        // Torso movement
        float delta = Input.GetAxis("Horizontal");
        torso.AddTorque(Vector3.up*delta*turnTorque);

        // Jumping
        if (Input.GetKey(KeyCode.Space)) {
            SetAllMuscles(true);
        } else {
            SetAllMuscles(false);
        }
    }

    void SetAllMuscles(bool isJump) {
        foreach (FrogMuscle muscle in _muscles) {
            muscle.Set(isJump);
        }
    }
}
