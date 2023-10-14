using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPiece : MonoBehaviour
{
    //This script takes care of the colors when the ball rolls over the ground

    public bool isColored = false;

    public void changeColor(Color color)
    {
        GetComponent<MeshRenderer>().material.color = color;
        isColored = true;

        GameManager.singleton.CheckCompleted();
    }
}
