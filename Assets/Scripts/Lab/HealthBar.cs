using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // ตัวแปรสำหรับควบคุมแถบ HP
    public Image healthBarImage;

    // ฟังก์ชันในการอัพเดทแถบ HP ตามค่า HP ปัจจุบัน
    public void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        // คำนวณเปอร์เซ็นต์ของ HP ที่เหลือ
        float fillAmount = currentHealth / maxHealth;
        // ปรับขนาดแถบให้ตรงตามเปอร์เซ็นต์ที่เหลือ
        healthBarImage.fillAmount = fillAmount;
    }
}