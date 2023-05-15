using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUIManager : MonoBehaviour
{
    public Image qSkillCoolDownImage;
    public Image wSkillCoolDownImage;
    public Image eSkillCoolDownImage;

    public void EnableSkillCoolDownImg(float coolDown, SkillType skillType)
    {
        switch(skillType)
        {
            case SkillType.Q:
                StartCoroutine("StartQSkillCoolDownCoroutine", coolDown);
                break;
            case SkillType.W:
                StartCoroutine("StartWSkillCoolDownCoroutine", coolDown);
                break;
            case SkillType.E:
                StartCoroutine("StartESkillCoolDownCoroutine", coolDown);
                break;
        }
    }

    IEnumerator StartQSkillCoolDownCoroutine(float coolDown)
    {
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
    }

    IEnumerator StartWSkillCoolDownCoroutine(float coolDown)
    {
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
    }

    IEnumerator StartESkillCoolDownCoroutine(float coolDown)
    {
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
    }
}
