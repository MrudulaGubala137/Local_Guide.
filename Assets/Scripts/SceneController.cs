using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public static string keyWord;

    /*  public void Start()
      {
          string url = "https://bit.ly/3LxxMrM";
          StartCoroutine(GetRequest(url));
      }*/

    public void Quit()
    {
        Application.Quit();

    }
    public void GoNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void KeyWordForGoogle(string keyWordName)
    {
        keyWord = keyWordName;
        Debug.Log(keyWord);
        //string url = "https://bit.ly/3LxxMrM";
        // StartCoroutine(GetRequest());

    }
}
   

// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.



  /*  IEnumerator GetRequest()
    {
        string uri = "https://bit.ly/3LxxMrM";
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            Debug.Log("in coroutine function");
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();
            Debug.Log("Send Request Down");

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    break;
            }
        }
    }
}*/


