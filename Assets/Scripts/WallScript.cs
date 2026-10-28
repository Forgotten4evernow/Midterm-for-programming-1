using UnityEngine;

public class WallScript : MonoBehaviour
{
    public CoinScript Coin;
    public PlayerScript Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Coin = GameObject.FindFirstObjectByType<CoinScript>();
        Player = GameObject.FindFirstObjectByType<PlayerScript>();
        transform.position = Coin.transform.position + new Vector3(3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Coin.transform.position - new Vector3(Player.transform.position.x, 0, 0);
    }
}
