using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour {

	public ObjectPooler coinPool;

	public float distanceBetweenCoins;
    private float distancey;
    private float distancex;

    private void Awake()
    {
        distancey = Random.Range(1, 8);
        distancex = Random.Range(5, 10);
    }
    public void Update()
    {
        distancey = Random.Range(1, 7);
        distancex = Random.Range(5, 10);
    }

    public void SpawnCoins (Vector3 startPosition){

		GameObject coin1 = coinPool.GetPooledObject();
		coin1.transform.position = new Vector3(startPosition.x + distancex, startPosition.y + distancey, 35);
		coin1.SetActive (true);

		GameObject coin2 = coinPool.GetPooledObject();
		coin2.transform.position = new Vector3(startPosition.x - distanceBetweenCoins + distancex, startPosition.y + distancey, 35);
		coin2.SetActive (true);

		GameObject coin3 = coinPool.GetPooledObject();
		coin3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + distancex, startPosition.y + distancey, 35 );
		coin3.SetActive (true);
	}

}
