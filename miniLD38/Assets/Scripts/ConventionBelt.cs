using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class ConventionBelt : MonoBehaviour
{
    [HideInInspector]
    public Vector3 MovingDirection;

    public int BeltSpeed = 5;
    void Start()
    {
        MovingDirection = Vector3.right;
    }

    void MoveBelt(Collision2D col)
    {
        var gm = col.gameObject;
        var rigid = gm.GetComponent<Rigidbody2D>();
        if (gm.tag == "part")
        {
            rigid.velocity = MovingDirection * BeltSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        MoveBelt(col);
    }

    void OnCollisionStay2D(Collision2D col)
    {
        MoveBelt(col);
    }

    public void ChangeDirection()
    {
        MovingDirection = MovingDirection == Vector3.right ? Vector3.left : Vector3.right;
    }
}
