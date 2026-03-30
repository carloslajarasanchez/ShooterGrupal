using UnityEngine;

public class HealthPotion : Item
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Health Potion used +20Vida!");
        ServiceLocator.Get<Player>().AddLives(20);
    }
}
