using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TripleBallPowerup : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI countText;
    void SetCountText()
    {
        countText.text = "ThreeBall";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject temp = collision.gameObject;
        for (int i = 0; i < 2;i++)
            {
            GameObject newBall = Instantiate(temp);
            newBall.transform.position = new Vector2(i, i);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        SetCountText();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
