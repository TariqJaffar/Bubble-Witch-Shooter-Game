using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FairyManager : MonoBehaviour
{
    public Transform fairies;
    public Transform[] spawn;
    public GameObject[] spawnFairies;
    private void Start()
    {
        
        for (int i = 0; i < spawn.Length; i++)
        {
            GameObject f = Instantiate(fairies.gameObject, spawn[i]);
            spawnFairies[i] = f;
        }

        fairymoving();
       StartCoroutine( wait());

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        fairymoving();
       StartCoroutine( wait());
    }
    void fairymoving()
    {
        for (int i = 0; i < spawn.Length; i++)
        {
            int j = Random.Range(-12, 12);
            int k = Random.Range(-9, 36);
            spawnFairies[i].transform.DOMove(new Vector3(j, k, 0), 8);
        }
    }



}
