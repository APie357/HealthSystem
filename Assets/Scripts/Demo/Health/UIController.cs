using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject player;

    private HealthController playerHealth;

    private void Awake()
    {
        playerHealth = player.GetComponent<HealthController>();
        text.text = "Player health: " + playerHealth.currentHealth + "\nPlayer dead: " + playerHealth.isDead;
    }

    public void PlayerHealthUpdate(GameObject player)
    {
        text.text = "Player health: " + playerHealth.currentHealth + "\nPlayer dead: " + playerHealth.isDead;
    }
}
