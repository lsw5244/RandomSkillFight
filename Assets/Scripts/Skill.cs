using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Skill : MonoBehaviour
{
    [SerializeField]
    Image SkillQIcon;
    [SerializeField]
    Image SkillWIcon;
    [SerializeField]
    Image SkillEIcon;

    public float QSkillCoolTime = 0;
    public float WSkillCoolTime = 0;
    public float ESkillCoolTime = 0;

    public abstract void SkillQ();
    public abstract void SkillW();
    public abstract void SkillE();
}
