using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Animator animator;

    public float JumpStrength;
    public float JumpDecay;
    private float _jumpStrength;

    public bool IsJumping;

    void Start() {
        animator = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update () {

        if (animator.GetBool("Ground") && Input.GetKeyDown(KeyCode.Space)) {
            IsJumping = true;
            _jumpStrength = JumpStrength;
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            IsJumping = false;
        }
	}

    void FixedUpdate() {
        if (IsJumping) {

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpStrength);
            _jumpStrength *= JumpDecay;
        }
    }
}
