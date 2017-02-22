using System;
using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine;


/// <summary>
/// Usage:
/// where onSuccess is callback method, in that method you can show results.
/// 
/// StartCoroutine(GetLeaderBoard(onSuccess));
/// private void onSuccess(string result)
///    {
///        print(result);
///    }
/// </summary>
public static class LeaderBoard
{
    private static string _apikey = null;
    private const string GetUrl = "https://dollarone.games/elympics/getHighscores";
    private const string SubmitUrl = "https://dollarone.games/elympics/submitHighscore";

    public static void SetApiKey(string apiKey)
    {
        _apikey = apiKey;
    }

    public static IEnumerator GetLeaderBoard(Action<PlayerScoreObject[], string> callbackOnSuccess)
    {
        if (_apikey == null)
        {
            callbackOnSuccess(null, "API KEY NOT SET!");
        }
        WWWForm form = new WWWForm();
        form.AddField("key", _apikey);
        byte[] rawData = form.data;
        var headers = form.headers;
        var result = new WWW(GetUrl, rawData, headers);
        yield return result;

        var po = JsonHelper.getJsonArray(result.text);
        callbackOnSuccess(po, "ok");
    }

    public static IEnumerator SetScore(string name, int score, Action<string> callbackOnSuccess = null)
    {
        if (_apikey == null)
        {
            if (callbackOnSuccess != null) callbackOnSuccess("API KEY NOT SET!");
        }
        //get rid of spaces and dollar characters (not idea why i hate dollars xD)
        var pattern = new Regex("\\s\\$");
        name = pattern.Replace(name, string.Empty);
        var form = new WWWForm();
        form.AddField("key", _apikey);
        form.AddField("name", name);
        form.AddField("score", score);

        var result = new WWW(SubmitUrl, form);
        yield return result;
        if (callbackOnSuccess != null)
            callbackOnSuccess("ok");
    }

    [Serializable]
    public class PlayerScoreObject
    {
        public string name;
        public int score;
    }

    //Unity does not support parsing of JSON array, have to be array appended
    //From StackOverflow https://forum.unity3d.com/threads/how-to-load-an-array-with-jsonutility.375735/
    private static class JsonHelper
    {
        public static PlayerScoreObject[] getJsonArray(string json)
        {
            if (json == null || json == "{}")
                return null;
            string newJson = "{ \"array\": " + json + "}";
            Wrapper<PlayerScoreObject> wrapper = JsonUtility.FromJson<Wrapper<PlayerScoreObject>>(newJson);
            return wrapper.array;
        }

        [Serializable]
        private class Wrapper<T>
        {
            public T[] array;
        }
    }
}

