using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this.gameObject);
        }
    }


    #region Resources
    [SerializeField]
    int maxFood = 100; 
    [SerializeField]
    int maxWood = 100;

    public int currentFood;
    public int currentWood;
    public int villagers;
    public int freeVillagers;

    #endregion

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFood >= maxFood)
        {
            currentFood = maxFood;
        }
        if(currentWood >= maxWood)
        {
            currentWood = maxWood;
        }
    }


    public void UpdateWood(int x)
    {
        currentWood += x;
    }

    public void UpdateFood(int x)
    {
        currentFood += x;
    }
}
