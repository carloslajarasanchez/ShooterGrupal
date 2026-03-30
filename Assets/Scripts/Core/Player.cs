using NUnit.Framework;
using System.Collections.Generic;

public enum States
{
    Small,
    Big,
    Fire
}
public class Player
{
    public int Lives { get; private set; } = 3;
    public int Points { get; private set; }

    public List<Item> Inventory { get; private set; } = new List<Item>();


    /// <summary>
    /// Resta vidas al player
    /// </summary>
    /// <param name="amount"></param>
    public void RestLives(int amount)
    {
        Lives -= amount;

        if (Lives <= 0)
        {
            ServiceLocator.Get<CustomEvents>().OnGameOver?.Invoke();
        }

        ServiceLocator.Get<CustomEvents>().OnLivesChanged?.Invoke();
    }

    /// <summary>
    /// Añade vidas al player
    /// </summary>
    /// <param name="amount"></param>
    public void AddLives(int amount)
    {
        ServiceLocator.Get<AudioManager>().PlaySound("Live");
        Lives += amount;
        ServiceLocator.Get<CustomEvents>().OnLivesChanged?.Invoke();
    }

    public void AddPoints(int amount)
    {
        Points += amount;
        ServiceLocator.Get<CustomEvents>().OnPointsChanged?.Invoke();
    }

    public void ResetPlayer()
    {
        Lives = 3;
        Points = 0;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
        ServiceLocator.Get<CustomEvents>().OnInventoryChanged?.Invoke();
    }

    public void RemoveItem(Item item) {
        Inventory.Remove(item);
        ServiceLocator.Get<CustomEvents>().OnInventoryChanged?.Invoke();
    }
}
