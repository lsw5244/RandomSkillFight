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
        Debug.Log("Q스킬 발동 !!!");
    }

    public override void SkillW()
    {
        Debug.Log("W스킬 발동 !!!");
    }

    public override void SkillE()
    {
        Debug.Log("E스킬 발동 !!!");
    }
}
