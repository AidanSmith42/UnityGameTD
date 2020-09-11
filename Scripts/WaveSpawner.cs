using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 0;

	public Wave[] waves;
   // public Wave[] waves2;

	public Transform spawnPoint;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public Text waveCountdownText;

	public GameManager gameManager;

	private int waveIndex = 0;
   // private int waveIndex2 = 0;

	void Update ()
	{
		if (EnemiesAlive > 0)
		{
			return;
		}

		if (waveIndex == waves.Length)
		{
			gameManager.WinLevel();
			this.enabled = false;
		}

		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
			return;
		}

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

		//waveCountdownText.text = string.Format("{0:00.00}", countdown);
	}

	IEnumerator SpawnWave ()
	{
		PlayerStats.Rounds++;

		Wave wave = waves[waveIndex];
        //Wave wave2 = waves2[waveIndex2];

        EnemiesAlive = wave.count*3;

		for (int i = 0; i < wave.count; i++)
		{
			SpawnEnemy(wave.enemy);
			yield return new WaitForSeconds(1f / wave.rate);
		}
        waveIndex++;
       // for (int i=0;i <wave2.count; i++)
        //{
       //     SpawnEnemy(wave2.enemy);
       //     yield return new WaitForSeconds(1f / wave2.rate);
      //  }
        
       // waveIndex2++;
	}

	void SpawnEnemy (GameObject enemy)
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        Instantiate(enemy, spawnPoint2.position, spawnPoint2.rotation);
        Instantiate(enemy, spawnPoint3.position, spawnPoint3.rotation);
	}

}
