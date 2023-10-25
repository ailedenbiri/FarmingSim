using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    [SerializeField] private Animator PlayerAC;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


   public void ManageAnimations(Vector3 move)
   {
      if(move.magnitude > 0)
      {
            PlayRunAnimation();

            PlayerAC.transform.forward = move.normalized;
      }
        else
        {
            PlayIdleAnimation();
        }
   }
    
    private void PlayRunAnimation()
    {
        PlayerAC.Play("RUN");
    }

    private void PlayIdleAnimation()
    {
        PlayerAC.Play("IDLE");
    }

}
