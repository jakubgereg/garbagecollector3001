using UnityEngine;

public class dasda : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
            rigid.velocity = Vector2.right * 5;
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        MoveBelt(col);


    }
}
