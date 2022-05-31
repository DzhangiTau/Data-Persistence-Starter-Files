using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    public void onInputDeselected(string s)
    {
        GameData.Instance.PlayerName = s;
    }

    public void onStartClicked()
    {
        GameData.Instance.SaveData();
        SceneManager.LoadScene(1);
    }

    public void onQuitClicked()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
