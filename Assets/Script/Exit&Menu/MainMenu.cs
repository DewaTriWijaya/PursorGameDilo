using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button[] btn;

    private void Start()
    {
        for(int a = 0; a < btn.Length; a++)
        {
            int index = a + 1;
            btn[a].onClick.AddListener(() => { SceneManager.LoadScene(index); });
        }
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
