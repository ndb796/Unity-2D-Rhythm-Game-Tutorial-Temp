using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResultManager : MonoBehaviour {

    public Text musicTitleUI;
    public Text scoreUI;
    public Text maxComboUI;

	void Start () {
        musicTitleUI.text = "" + PlayerInformation.musicTitle;
        scoreUI.text = "점수: " + (int) PlayerInformation.score;
        maxComboUI.text = "최대 콤보: " + PlayerInformation.maxCombo;
    }
	
}