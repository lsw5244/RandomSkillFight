using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private float maxHp = 100f;
    private float currHp;

    [SerializeField]
    private float atk = 10f;

    private void Start()
    {
        currHp = maxHp;
    }

    public void Die()
    {
        GetComponent<UseSkill>().enabled = false;
        GetComponent<PlayerMove>().enabled = false;
    }

    public void GetDamage(float damge)
    {
        currHp -= damge;

        if (currHp <= 0)
            Die();
    }
}
