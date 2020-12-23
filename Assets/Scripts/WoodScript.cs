using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodScript : MonoBehaviour
{

    public int curWorkers;
    public int maxWorkers;

    public int baseWood;

    private void Update()
    {
        if (curWorkers != 0)
        {
            StartCoroutine(AddWood(5, baseWood * curWorkers));
        }
    }


    IEnumerator AddWood(int x, int t)
    {
        yield return new WaitForSeconds(t);

        GameManager.instance.UpdateWood(x);

    }


    public void AddWorker()
    {
        if (GameManager.instance.villagers != 0 && GameManager.instance.freeVillagers != 0)
        {
            GameManager.instance.villagers -= 1;
            curWorkers += 1;
        }
    }

}
