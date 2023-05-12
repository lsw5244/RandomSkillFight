using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUIManager : MonoBehaviour
{
    public Image qSkillCoolTimeImage;
    public Image wSkillCoolTimeImage;
    public Image eSkillCoolTimeImage;

    public void StartQSkillCollTime(float coolTime)
    {
        StartCoroutine("StartQSkillCollTimeCoroutine", coolTime);
    }

    IEnumerator StartQSkillCollTimeCoroutine(float coolTime)
    {
        qSkillCoolTimeImage.fillAmount = 1f;
        float coolTimeProgress = 0.0f;

        while(true)
        {
            coolTimeProgress += Time.deltaTime;

            if(coolTimeProgress >= coolTime)
            {
                break;
            }

            qSkillCoolTimeImage.fillAmount = coolTimeProgress / coolTime;
            yield return null;
        }
        qSkillCoolTimeImage.fillAmount = 0f;

    }

    public void StartWSkillCollTime(float coolTime)
    {

    }

    IEnumerator StartWSkillCollTimeCoroutine(float coolTime)
    {
        yield return null;
    }

    public void StartESkillCollTime(float coolTime)
    {

    }

    IEnumerator StartESkillCollTimeCoroutine(float coolTime)
    {
        yield return null;
    }
}
