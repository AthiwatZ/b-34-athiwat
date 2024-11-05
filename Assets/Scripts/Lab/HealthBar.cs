using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // ���������Ѻ�Ǻ���ᶺ HP
    public Image healthBarImage;

    // �ѧ��ѹ㹡���Ѿഷᶺ HP ������ HP �Ѩ�غѹ
    public void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        // �ӹǳ�����繵�ͧ HP ��������
        float fillAmount = currentHealth / maxHealth;
        // ��Ѻ��Ҵᶺ���ç��������繵��������
        healthBarImage.fillAmount = fillAmount;
    }
}