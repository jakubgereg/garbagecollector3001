using UnityEngine;

public class dasda : MonoBehaviour
{
    Vector3 direction;
    void Start()
    {
        direction = Vector3.right;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        MoveBelt(col);
    }

    void MoveBelt(Collision2D col)
    {
        var gm = col.gameObject;
        var rigid = gm.GetComponent<Rigidbody2D>();
        if (gm.tag == "part")
        {
            rigid.velocity = direction * 5;
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        MoveBelt(col);
    }

    public void changeDirection()
    {
        if (direction == Vector3.right)
            direction = Vector3.left;
        else
            direction = Vector3.right;
    }

}
