using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    enum level { Map_1, Map_2, Map_3, END }
    [SerializeField] level _selectedLevel = level.Map_1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("i got " + other.tag);
        if (other.CompareTag("Player"))
        {
            Debug.Log("next level " + _selectedLevel.ToString());
            SceneManager.LoadScene(_selectedLevel.ToString());
        }
    }

}
