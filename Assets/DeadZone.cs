using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private GameObject _spawn;
    [SerializeField] private GameObject _player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _player.transform.position = new Vector3(_spawn.transform.position.x, _spawn.transform.position.y, _spawn.transform.position.z);
        }
    }
}
