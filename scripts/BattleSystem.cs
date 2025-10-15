using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;

    [SerializeField] int playerHP = 10;
    [SerializeField] int maxPlayerHP = 10;
    [SerializeField] int playerEC = 100;
    [SerializeField] int maxPlayerEC = 100;

    [SerializeField] int enemyHP = 10;
    [SerializeField] int maxEnemyHP = 10;

    [SerializeField] Text playerHPText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
