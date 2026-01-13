using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] GameObject CoinPrefab;
    [SerializeField] int CoinCount = 10;

    void Start()
    {
        for (int i = 0; i < CoinCount; i++)
        {
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);
            Vector3 position = new Vector3(x, 1f, z);
            Instantiate(CoinPrefab, position, Quaternion.identity);
        }
    }

}
