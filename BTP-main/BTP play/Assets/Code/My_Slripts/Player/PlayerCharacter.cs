using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCharacter : MonoBehaviour
{
    //Количество жизни у игрока
    public int health;
    public int maxHealth;
    public static bool alive = false;

    private void Start()
    {
        //Инициализируем
        health = 100;
        maxHealth = 100;
    }


    // сохранение на бинарном файле
    /*
    /// <summary>
    ///     public void SavePlayer()
    {
        SaveSysteam.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSysteam.LoadPlayer();

        _health = data._health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

    }
    /// </summary>
    */
    //Ранение
    public void Hurt(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            alive = true;
            SceneManager.LoadScene("Menu");
        }
    }
    public void SetHealth(int bonus)
    {
        health += bonus;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
       
}
