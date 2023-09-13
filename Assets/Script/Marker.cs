using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    public MarkerMassiv MarkerMassiv;
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            MarkerMassiv.Markers[MarkerMassiv.i + 1].SetActive(true);
            MarkerMassiv.i += 1;
            if (MarkerMassiv.i != 10) {
                    gameObject.SetActive(false);
                }
        }
    }
}
