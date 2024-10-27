using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gameplay : MonoBehaviour
{
    public TextMeshPro score;
    public TextMeshPro numberOfMoves;
    public GameObject imageEducation;

    void Start()
    {
        imageEducation.SetActive(true);
    }

    
}
