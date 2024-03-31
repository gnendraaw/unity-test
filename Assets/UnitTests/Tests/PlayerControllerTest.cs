using NUnit.Framework;
using UnityEngine;
using UnityTest.UnitTest;

public class PlayerControllerTest
{
    [Test]
    public void PlayerInitial() {
        // Arrange
        int initialHealth = 10;
        var go = new GameObject();
        var player = go.AddComponent<PlayerController>();

        // Act
        player.Initialize(initialHealth);

        // Assert
        Assert.AreEqual(initialHealth, player.Health);
    }

    [Test]
    public void PlayerTakeDamage()
    {
        // Arrange
        int initialHealth = 10;
        int damage = 5;
        GameObject go = new GameObject();
        PlayerController playerController = go.AddComponent<PlayerController>();

        // Act
        playerController.Initialize(initialHealth);
        playerController.TakeDamage(damage);

        // Assert
        Assert.AreEqual(initialHealth - damage, playerController.Health);
    }

}
