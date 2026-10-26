using UnityEngine;

public class HazardScript : MonoBehaviour
{
    public int Speed = 5;
    public PlayerScript Player;
    public Vector3 PlayerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindFirstObjectByType<PlayerScript>();
        //GetComponent can find the transform of an object, then find its position, rotation, or scale
        //this is useful for finding other gameObjects that this script is not attached to
        PlayerPosition = Player.gameObject.GetComponent<Transform>().position;
        //follow player until it makes contact

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = Player.gameObject.transform.position;
        Debug.DrawRay(PlayerPosition, Vector3.up, Color.magenta);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
        }
    }
}