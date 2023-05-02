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

    public abstract void SkillQ();
    public abstract void SkillW();
    public abstract void SkillE();
}
