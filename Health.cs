using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Health : MonoBehaviour
{
    int currentHealth = 5;
    public TextMeshProUGUI TMPHealth;

    void Start()
    {
        TMPHealth.text = (currentHealth).ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor" || other.gameObject.tag == "Coin" )
        {
            return;
        }
        else
        {
            currentHealth--;
            TMPHealth.text = (currentHealth).ToString();
        }
    }
}
