using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmScript : MonoBehaviour
{
    public int curWorkers;
    private int maxWorkers;

    public int baseFood;

    private void Update()
    {
       if(curWorkers != 0)
        {
            StartCoroutine(AddFood(5, baseFood*curWorkers));
        }
    }


    IEnumerator AddFood(int x, int t)
    {
        yield return new WaitForSeconds(t);

        GameManager.instance.UpdateFood(x);

    }


    public void AddWorker()
    {
        if(GameManager.instance.villagers != 0 && GameManager.instance.freeVillagers != 0)
        {
            GameManager.instance.villagers -= 1;
            curWorkers += 1;
        }
    }

}
