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
        if(Input.GetKey(KeyCode.Q))
        {
            selectSkill.SkillQ();
        }

        if (Input.GetKey(KeyCode.W))
        {
            selectSkill.SkillW();
        }

        if (Input.GetKey(KeyCode.E))
        {
            selectSkill.SkillE();
        }
    }
}
