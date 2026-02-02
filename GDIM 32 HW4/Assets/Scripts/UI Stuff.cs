using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIStuff : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsUI;
    private int _points;
    

    // Start is called before the first frame update
    void Start()
    {
        _pointsUI.text = "Points: " + _points.ToString();
        Locator.Instance.Player.AddPoint += HandlePoints;
        Locator.Instance.Player.Died += Death;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandlePoints(int points)
    {
        _pointsUI.text = "Points: " + points.ToString();
    }

    void Death()
    {
        _pointsUI.text = "GAME OVER!";
    }

}
