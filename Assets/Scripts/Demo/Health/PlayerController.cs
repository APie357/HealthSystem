using UnityEngine;

[RequireComponent(typeof(HealthController))]
public class PlayerController : MonoBehaviour
{
    private bool healKeyPressed = false;
    private bool damageKeyPressed = false;
    private HealthController health;

    private void Awake()
    {
        health = GetComponent<HealthController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && !healKeyPressed)
        {
            healKeyPressed = true;
            health.Heal(10);
        }
        else if (!Input.GetKeyDown(KeyCode.H) && healKeyPressed)
            healKeyPressed = false;

        if (Input.GetKeyDown(KeyCode.N) && !damageKeyPressed)
        {
            damageKeyPressed = true;
            health.Damage(10);
        }
        else if (!Input.GetKeyDown(KeyCode.N) && damageKeyPressed)
            damageKeyPressed = false;
    }
}
