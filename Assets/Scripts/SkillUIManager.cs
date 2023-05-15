using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUIManager : MonoBehaviour
{
    public Image qSkillCoolDownImage;
    public Image wSkillCoolDownImage;
    public Image eSkillCoolDownImage;

    public void EnableSkillCoolDownImg(float coolDown, SkillType skillType, UseSkill useSkill)
    {
        switch(skillType)
        {
            case SkillType.Q:
                StartCoroutine(StartQSkillCoolDownCoroutine(coolDown, useSkill));
                break;
            case SkillType.W:
                StartCoroutine(StartWSkillCoolDownCoroutine(coolDown, useSkill));
                break;
            case SkillType.E:
                StartCoroutine(StartESkillCoolDownCoroutine(coolDown, useSkill));
                break;
        }
    }

    IEnumerator StartQSkillCoolDownCoroutine(float coolDown, UseSkill useSkill)
    {
        useSkill.qSkillReady = false;

        qSkillCoolDownImage.fillAmount = 1f;
        float coolTimeProgress = 0.0f;
        while(true)
        {
            coolTimeProgress += Time.deltaTime;

            if(coolTimeProgress >= coolDown)
            {
                break;
            }

            qSkillCoolDownImage.fillAmount = 1.0f - coolTimeProgress / coolDown;
            yield return null;
        }
        qSkillCoolDownImage.fillAmount = 0f;

        useSkill.qSkillReady = true;
    }

    IEnumerator StartWSkillCoolDownCoroutine(float coolDown, UseSkill useSkill)
    {
        useSkill.wSkillReady = false;

        wSkillCoolDownImage.fillAmount = 1f;
        float coolTimeProgress = 0.0f;
        while (true)
        {
            coolTimeProgress += Time.deltaTime;

            if (coolTimeProgress >= coolDown)
            {
                break;
            }

            wSkillCoolDownImage.fillAmount = 1.0f - coolTimeProgress / coolDown;
            yield return null;
        }
        wSkillCoolDownImage.fillAmount = 0f;

        useSkill.wSkillReady = true;
    }

    IEnumerator StartESkillCoolDownCoroutine(float coolDown, UseSkill useSkill)
    {
        useSkill.eSkillReady = false;

        eSkillCoolDownImage.fillAmount = 1f;
        float coolTimeProgress = 0.0f;
        while (true)
        {
            coolTimeProgress += Time.deltaTime;

            if (coolTimeProgress >= coolDown)
            {
                break;
            }

            eSkillCoolDownImage.fillAmount = 1.0f - coolTimeProgress / coolDown;
            yield return null;
        }
        eSkillCoolDownImage.fillAmount = 0f;

        useSkill.eSkillReady = true;
    }
}
