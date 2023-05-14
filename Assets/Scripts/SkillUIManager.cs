using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUIManager : MonoBehaviour
{
    public Image qSkillCoolDownImage;
    public Image wSkillCoolDownImage;
    public Image eSkillCoolDownImage;

    public void EnableQSkillCoolDownImg(float coolDown)
    {
        StartCoroutine("StartQSkillCoolDownCoroutine", coolDown);
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

    public void StartWSkillCoolDown(float coolDown)
    {
        StartCoroutine("StartWSkillCoolDownCoroutine", coolDown);
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

    public void StartESkillCoolDown(float coolDown)
    {
        StartCoroutine("StartESkillCoolDownCoroutine", coolDown);
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
