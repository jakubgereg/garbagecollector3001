using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickNameController : MonoBehaviour {

    int nickLength;
    public InputField nickNameField;
    public List<string> firstNickPart;
    public List<string> secondNickPart;
    public List<string> thirdNickPart;

    public void generateNickName()
    {
        string nick = "";
        nickLength = Random.Range(2,4);

        if(nickLength == 2)
        {
            nick = firstNickPart[Random.Range(0, firstNickPart.Count)] +
                thirdNickPart[Random.Range(0, thirdNickPart.Count)];
            DataContainer.nickName = nick;
        }

        if(nickLength == 3)
        {
            nick = firstNickPart[Random.Range(0, firstNickPart.Count)] +
                secondNickPart[Random.Range(0, secondNickPart.Count)] +
                 thirdNickPart[Random.Range(0, thirdNickPart.Count)];
            DataContainer.nickName = nick;
        }

        nickNameField.text = nick;
    }
}
