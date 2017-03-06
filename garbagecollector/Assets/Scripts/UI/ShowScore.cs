using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ShowScore : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        var result = GetComponent<Text>();

        result.text = "Your score is: " + DataContainer.score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
