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

    [HideInInspector]
    public bool qSkillReady = true;
    [HideInInspector]
    public bool wSkillReady = true;
    [HideInInspector]
    public bool eSkillReady = true;

    private void Start()
    {
        selectSkill = skills[skillIdx];
        skillUIManager = GameObject.Find("SkillUIManager").GetComponent<SkillUIManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && qSkillReady == true)
        {
            skillUIManager.EnableSkillCoolDownImg(selectSkill.QSkillCoolTime, SkillType.Q, GetComponent<UseSkill>());
            selectSkill.SkillQ();
        }

        if (Input.GetKeyDown(KeyCode.W) && wSkillReady == true)
        {
            skillUIManager.EnableSkillCoolDownImg(selectSkill.WSkillCoolTime, SkillType.W, GetComponent<UseSkill>());
            selectSkill.SkillW();
        }

        if (Input.GetKeyDown(KeyCode.E) && eSkillReady == true)
        {
            skillUIManager.EnableSkillCoolDownImg(selectSkill.ESkillCoolTime, SkillType.E, GetComponent<UseSkill>());
            selectSkill.SkillE();
        }
    }
}
