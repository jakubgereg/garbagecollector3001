using System.Linq;
using UnityEngine;

[RequireComponent(typeof(TextMesh))]
public class ScoreBoardController : MonoBehaviour
{
    public string ApiKey = "YourApiKey";

    [Header("Score Board Style")]
    public int ShowMaxPlayers = 10;
    public bool ReverseOrder;
    public bool SortByScore = true;
    public string HeaderLabel = "Score Board";
    public string Delimiter = ":";
    public string PointSuffix = "points";

    private TextMesh _textMesh;
    // Use this for initialization
    void Start()
    {
        LeaderBoard.SetApiKey(ApiKey);
        _textMesh = GetComponent<TextMesh>();

        //StartCoroutine(LeaderBoard.SetScore("pan", 1, SetScoreCallback));
        StartCoroutine(LeaderBoard.GetLeaderBoard(LeaderBoardCallback));
    }

    private void SetScoreCallback(string exception)
    {
        if (exception != null)
        {
            print("SetScore= " + exception);
        }
    }

    private void LeaderBoardCallback(LeaderBoard.PlayerScoreObject[] obj, string exception)
    {
        if (exception != null)
        {
            Debug.LogWarning("GetLeaderBoard= " + exception);
        }

        string result = string.Empty;
        result += HeaderLabel + "\n\n";
        int i = 1;


        if (obj != null)
        {
            if (SortByScore) obj = obj.OrderBy(x => x.score).ToArray();
            if (!ReverseOrder) obj = obj.Reverse().ToArray();

            foreach (var pl in obj)
            {
                if (i > ShowMaxPlayers) break;

                if (string.IsNullOrEmpty(pl.name))
                    pl.name = "Unknown";

                result += i + ". " + pl.name + Delimiter + pl.score + PointSuffix + "\n";
                i++;
            }
        }

        _textMesh.text = result;
    }


}
