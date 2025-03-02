using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Gameplay : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text numberOfMoves;
    [SerializeField] private GameObject imageEducation;
    [SerializeField] private GameObject[] balls;
    public Animator boom;
    private int countMove;

    public void StartGame(bool start)
    {
        if (start)
            imageEducation.SetActive(true);
        else
            imageEducation.SetActive(false);
    }

    private void Spawn()
    {
        
    }

    private void Boom()
    {
        
    }

    private void Counter()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.rawPointerPress.tag == "Ball")
        {
            
            StartGame(false);
            
            countMove++;
            numberOfMoves.text = "lol";
        }
    }
}
