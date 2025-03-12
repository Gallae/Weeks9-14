using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventsGym : MonoBehaviour
{
    public Image steak;
    public GameObject planet;
    public float spawnDistance = 4;

    public void CookSteak()
    {
        steak.color = Color.green;
    }
    public void UncookSteak()
    {
        steak.color = Color.white;
    }
    public void SpawnPlanet()
    {
        Instantiate(planet,(Random.insideUnitCircle)*spawnDistance,Quaternion.identity);
    }
}
