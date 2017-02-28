using UnityEngine;

public class AutomaticDestroy : MonoBehaviour
{

    public float MaximumDistance = 30f;
    public float ActualDistance = 0f;
    // Use this for initialization
    private Vector3 mypositon;
    private Vector3 cameraPosition;
    void Start()
    {
        cameraPosition = Camera.main.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        mypositon = transform.position;

        ActualDistance = Vector3.Distance(cameraPosition, mypositon);
        if (ActualDistance > MaximumDistance)
            Destroy(gameObject);
    }
}
