using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float Point = 0;
    public Text ScoreUI;
    string ScoreString;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowScore();
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            Point = Point - 1;
        }

        if (collisionInfo.collider.tag == "Point")
        {
            Point = Point + 5;
        }
    }

    public void ShowScore()
    {
        ScoreString = Point.ToString();
        ScoreUI.text = ScoreString;
    }
}
