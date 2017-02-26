using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour {

    public List<Button> disableOnEmptyField;

    InputField input;

	void Start () {
        input = GetComponent<InputField>();

		foreach(Button b in disableOnEmptyField)
        {
            b.interactable = false;
        }
        input.text = "";
	}

    void Update() {
        if (input.text != "")
        {
            foreach (Button b in disableOnEmptyField)
            {
                b.interactable = true;
            }
        }else
            foreach (Button b in disableOnEmptyField)
            {
                b.interactable = false;
            }
    }
}
