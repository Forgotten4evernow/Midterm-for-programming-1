using UnityEngine;

public class HazardScript : MonoBehaviour
{
    public int Speed = 5;
    public PlayerScript Player;
    public Vector3 PlayerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Look for Player 
        Player = GetComponent<PlayerScript>();
        //follow player until it makes contact
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
        }
    }
}