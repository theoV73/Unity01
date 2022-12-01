using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    [SerializeField]
    private DataPlayer _dataPlayer;

    private void Start()
    {
        StartCoroutine(ReduceLifeCoroutine());
    }
    private IEnumerator ReduceLifeCoroutine()
    {
        while(_dataPlayer.CurrentLifePoints > 0)
        {
            yield return new WaitForSeconds(2);

            _dataPlayer.CurrentLifePoints -= 10;
        }

        
    }
}
