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

            qSkillCoolTimeImage.fillAmount = 1.0f - coolTimeProgress / coolTime;
            yield return null;
        }
        qSkillCoolTimeImage.fillAmount = 0f;
    }

    public void StartWSkillCollTime(float coolTime)
    {
        StartCoroutine("StartWSkillCollTimeCoroutine", coolTime);
    }

    IEnumerator StartWSkillCollTimeCoroutine(float coolTime)
    {
        wSkillCoolTimeImage.fillAmount = 1f;
        float coolTimeProgress = 0.0f;

        while (true)
        {
            coolTimeProgress += Time.deltaTime;

            if (coolTimeProgress >= coolTime)
            {
                break;
            }

            wSkillCoolTimeImage.fillAmount = 1.0f - coolTimeProgress / coolTime;
            yield return null;
        }
        wSkillCoolTimeImage.fillAmount = 0f;
    }

    public void StartESkillCollTime(float coolTime)
    {
        StartCoroutine("StartESkillCollTimeCoroutine", coolTime);
    }

    IEnumerator StartESkillCollTimeCoroutine(float coolTime)
    {
        eSkillCoolTimeImage.fillAmount = 1f;
        float coolTimeProgress = 0.0f;

        while (true)
        {
            coolTimeProgress += Time.deltaTime;

            if (coolTimeProgress >= coolTime)
            {
                break;
            }

            eSkillCoolTimeImage.fillAmount = 1.0f - coolTimeProgress / coolTime;
            yield return null;
        }
        eSkillCoolTimeImage.fillAmount = 0f;
    }
}
