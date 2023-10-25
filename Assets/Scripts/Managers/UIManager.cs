using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] private TextMeshProUGUI coinCountText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(Instance);
        }
    }
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void ShowCoinCountOnScreen(int coins)
    {
        coinCountText.text = coins.ToString();  
    }

}
