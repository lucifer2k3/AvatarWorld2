using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedUI : MonoBehaviour
{
    [SerializeField] private GameObject sleepUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Sleep()
    {
        PlayerStats.instance.Sleep();
        sleepUI.SetActive(false);
    }
    public void CloseSleepUI()
    {
        sleepUI.SetActive(false);
    }

}
