using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    int LevelLock;
    public Button[] buttons;
    public static LevelSelection instance;



    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        LevelLock = PlayerPrefs.GetInt("levelLock", 1);
        Debug.Log(LevelLock);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
           
        }
        for (int i = 0; i < LevelLock; i++)
        {
            buttons[i].interactable = true;
            
        }
    }

    public void OpenLevel(int levelIndex)
    {
        
        SceneManager.LoadScene(levelIndex);
        SoundManagerScript.instance.PlaySound(4);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
