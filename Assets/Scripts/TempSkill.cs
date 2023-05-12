using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempSkill : Skill
{
    private void Start()
    {
        QSkillCoolTime = 1f;
        WSkillCoolTime = 3f;
        ESkillCoolTime = 5f;
    }

    public override void SkillQ()
    {
        Debug.Log("Q��ų �ߵ� !!!");
    }

    public override void SkillW()
    {
        Debug.Log("W��ų �ߵ� !!!");
    }

    public override void SkillE()
    {
        Debug.Log("E��ų �ߵ� !!!");
    }
}
