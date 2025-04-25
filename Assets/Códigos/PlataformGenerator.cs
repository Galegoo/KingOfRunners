using UnityEngine;
using System.Collections;

public class PlataformGenerator : MonoBehaviour
{

    public GameObject thePlataform;
    public Transform generationPoint;

    private float plataformWidth;

   public ObjectPooler theObjectPool;

    private CoinGenerator theCoinGenerator;
    public float randomCoinTreshold;

    public float randomObstaculo;
    public ObjectPooler obstaculo;

    void Start()
    {
        plataformWidth = thePlataform.GetComponent<BoxCollider2D>().size.x;

        theCoinGenerator = FindObjectOfType<CoinGenerator>();
    }

    void Update()
    {


        if (transform.position.x < generationPoint.position.x)
        {

            transform.position = new Vector3(transform.position.x +1.15f, transform.position.y, transform.position.z);

            GameObject newPlataform = theObjectPool.GetPooledObject();
			newPlataform.transform.position = transform.position;
			newPlataform.transform.rotation = transform.rotation;
			newPlataform.SetActive (true);

            if (Random.Range(0f, 100f) < randomCoinTreshold)
            {
                theCoinGenerator.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.x));
            }

            if (Random.Range(0f, 100f) < randomObstaculo)
            {
                GameObject newObstaculo = obstaculo.GetPooledObject();
                newObstaculo.transform.position = new Vector3(transform.position.x + Random.RandomRange(-5f, 5f), -2.371852f, 38f);
				newObstaculo.transform.rotation = transform.rotation;
				newObstaculo.SetActive (true);
			}
                transform.position = new Vector3(transform.position.x + (plataformWidth /2), transform.position.y, transform.position.z);
            }
        }
    }
