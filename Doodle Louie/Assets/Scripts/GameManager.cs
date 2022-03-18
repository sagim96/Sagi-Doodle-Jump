using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 spwanPosition;
    public GameObject platformPrefab;
    public GameObject[] randomPlatform;
    public GameObject coin;
    public Vector3 coinSpwanPos;
    public GameObject enemy;
    public Vector3 enemySpawn;
    public Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            CreatePlatform();
        }
        for (int i = 0; i < 5; i++)
        {
            CreateRandomPlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y > spwanPosition.y - 15)
        CreatePlatform();
        CreateCoins();
        if (spwanPosition.y > 40)
        {
            createEnemy();
        }

    }

    void CreatePlatform()
    {
        int choose = Random.Range(0, randomPlatform.Length);
        float randx = Random.Range(-3.5f,2.5f);
        float randy = Random.Range(0.5f, 2);
        spwanPosition.y += randy;
        spwanPosition.x = randx;
        Instantiate(platformPrefab, spwanPosition, Quaternion.identity);
    }

    void CreateRandomPlatform()
    {
        int choose = Random.Range(0, randomPlatform.Length);
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(1.5f, 3f);
        spwanPosition.y += randy;
        spwanPosition.x = randx;
        Instantiate(randomPlatform[choose], spwanPosition, Quaternion.identity);
    }

    void CreateCoins()
    {
        float randx = Random.Range(-2.5f, 2.5f);
        float randy = Random.Range(0.5f, 2f);
        coinSpwanPos.y += randy;
        coinSpwanPos.x = randx;
        Instantiate(coin, coinSpwanPos, Quaternion.identity);
    }

    void createEnemy()
    {
        float randx = Random.Range(-2.5f, 2.5f);
        float randy = Random.Range(0.5f, 2);
        enemySpawn.y += randy;
        enemySpawn.x = randx;
        Instantiate(enemy, enemySpawn, Quaternion.identity);
    }




}

