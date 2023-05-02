using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempSkill : Skill
{
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
