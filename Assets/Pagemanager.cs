using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pagemanager : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages = new List<GameObject>();

    private int pagenr = 0;

    public void goleft()
    {
        if (pagenr > 0)
        {
            pages[pagenr].SetActive(false);
            pagenr--;
            pages[pagenr].SetActive(true);
        }
    }
    
    public void goright()
    {
        if (pagenr < pages.Count -1)
        {
            pages[pagenr].SetActive(false);
            pagenr++;
            pages[pagenr].SetActive(true);
        }
    }
}
