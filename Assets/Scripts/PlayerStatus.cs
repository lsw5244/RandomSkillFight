using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private float maxHp = 100f;
    private float currHp;

    private void Start()
    {
        currHp = maxHp;
    }

    public void Die()
    {
        if (currHp > 0)
            return;

        GetComponent<UseSkill>().enabled = false;
        GetComponent<PlayerMove>().enabled = false;
    }
}
