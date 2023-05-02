using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkill : MonoBehaviour
{
    [SerializeField]
    private Skill[] skills;

    private Skill selectSkill;

    private void Start()
    {
        selectSkill = skills[0];
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            selectSkill.SkillQ();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            selectSkill.SkillW();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            selectSkill.SkillE();
        }
    }
}
