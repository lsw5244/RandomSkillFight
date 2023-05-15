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
            skillUIManager.EnableSkillCoolDownImg(selectSkill.QSkillCoolTime, SkillType.Q);

            selectSkill.SkillQ();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            skillUIManager.EnableSkillCoolDownImg(selectSkill.WSkillCoolTime, SkillType.W);

            selectSkill.SkillW();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            skillUIManager.EnableSkillCoolDownImg(selectSkill.ESkillCoolTime, SkillType.E);

            selectSkill.SkillE();
        }
    }
}
