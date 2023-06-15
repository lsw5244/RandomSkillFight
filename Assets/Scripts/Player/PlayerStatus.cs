using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : PlayerStat
{
    [SerializeField]
    private Image hpBarImg;

    private void Start()
    {
        currHp = maxHp;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            GetDamage(10f);
        }
    }

    public void Die()
    {
        GetComponent<UseSkill>().enabled = false;
        GetComponent<PlayerMove>().enabled = false;
    }

    public void GetDamage(float damge)
    {
        currHp -= damge;

        hpBarImg.fillAmount = currHp / maxHp;

        if (currHp <= 0)
            Die();
    }
}
