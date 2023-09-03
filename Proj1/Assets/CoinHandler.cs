using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour
{
    public ParticleSystem DestroyParticle;

    public int ScoreCount;

    private GameManager _GameManager;

    private void Start()
    {
        _GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        DestroyParticle.transform.parent = null;
        DestroyParticle.Play();
        Destroy(gameObject);
        _GameManager.AddScore(ScoreCount);
    }

}
