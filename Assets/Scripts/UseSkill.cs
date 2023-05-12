using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkill : MonoBehaviour
{
    [SerializeField]
    private Skill[] skills;
    private Skill selectSkill;

    private int skillIdx = 0;

    private SkillUIManager skillUIManager;

    private void Start()
    {
        selectSkill = skills[skillIdx];
        skillUIManager = GameObject.Find("SkillUIManager").GetComponent<SkillUIManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            skillUIManager.StartQSkillCollTime(selectSkill.QSkillCoolTime);

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
