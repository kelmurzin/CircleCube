using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScorePlayer : MonoBehaviour
{
    [SerializeField] private Text _MaxScore;
    private Text _scoreText;
    private int _score;
    
    public void UpdateScore()
    {
        _score++;
        _scoreText.text = _score.ToString();

        if (PlayerPrefs.GetInt("Score") < _score)
        {
            PlayerPrefs.SetInt("Score", _score);
            _MaxScore.text ="MaxScore " + PlayerPrefs.GetInt("Score").ToString();
        }
    }

    private void Start()
    {
        _scoreText = GetComponent<Text>();
        _MaxScore.text = "MaxScore " + PlayerPrefs.GetInt("Score").ToString();
    }
  
}
