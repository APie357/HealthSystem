using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth { get; private set; } = 100f;
    public bool isDead { get; private set; } = false;

    public UnityEvent<GameObject> onUpdate;
    public UnityEvent<GameObject> onDamage;
    public UnityEvent<GameObject> onHeal;
    public UnityEvent<GameObject> onDeath;

    public void Damage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0f)
        {
            currentHealth = 0f;
            isDead = true;
            onDeath.Invoke(gameObject);
        }

        onUpdate.Invoke(gameObject);
        onDamage.Invoke(gameObject);
    }

    public void Heal(float amount)
    {
        Heal(amount, false);
    }

    public void Heal(float amount, bool allowAboveMax)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth && !allowAboveMax)
            currentHealth = maxHealth;

        onUpdate.Invoke(gameObject);
        onHeal.Invoke(gameObject);
    }
}
