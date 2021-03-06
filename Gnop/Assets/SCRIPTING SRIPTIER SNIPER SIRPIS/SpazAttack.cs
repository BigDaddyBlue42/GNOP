using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpazAttack : MonoBehaviour
{
    public TextMeshProUGUI countText;
    void SetCountText()
    {
        countText.text = "Glitch";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        GameObject temp = collision.gameObject;
        Vector3 p = temp.transform.position;
        temp.transform.position = new Vector3(Random.Range(-23f,24f), Random.Range(-13f, 17f), 0);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        SetCountText();
        Destroy(gameObject);
    }
}
