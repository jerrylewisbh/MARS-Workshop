using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSelector : MonoBehaviour
{
    [SerializeField] private List<GameObject> availableHats;
    private GameObject currentHat;

    public void ChangeHat()
    {
        var index = Random.Range(0, availableHats.Count);
        Destroy(currentHat);
        currentHat = Instantiate(availableHats[index], transform);
    }
}