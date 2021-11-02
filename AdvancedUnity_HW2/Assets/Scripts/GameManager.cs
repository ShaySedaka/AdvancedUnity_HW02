using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject playButton;

    [SerializeField]
    GameObject levelButtons;

    public void LevelSelect()
    {
        playButton.SetActive(false);
        levelButtons.SetActive(true);
    }

    public void BackToPlayMenu()
    {
        playButton.SetActive(true);
        levelButtons.SetActive(false);
    }

    public void LoadLevel(int levelNumber)
    {
        SceneManager.LoadScene("GolfLevel0" + levelNumber.ToString());
    }
}
