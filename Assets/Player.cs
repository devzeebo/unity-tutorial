using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Player : MonoBehaviour {

    public float AutoRunSpeed = 10f;

    public GameObject RobotBoy;
    private Vector3 _robotBoyLocalPosition;
    public Vector3 RobotBoyLocalPosition {
        get {
            return new Vector3(_robotBoyLocalPosition.x, RobotBoy.transform.localPosition.y);
        }
    }

    private bool _jumping;

    // Use this for initialization
    void Start() {
        _robotBoyLocalPosition = RobotBoy.transform.localPosition;
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.right * Time.deltaTime * AutoRunSpeed);
        RobotBoy.transform.localPosition = RobotBoyLocalPosition;

        _jumping = Input.GetKeyDown(KeyCode.Space);
    }

    void FixedUpdate() {
        RobotBoy.GetComponent<PlatformerCharacter2D>().Move(0, false, _jumping);

        _jumping = false;
    }
}
