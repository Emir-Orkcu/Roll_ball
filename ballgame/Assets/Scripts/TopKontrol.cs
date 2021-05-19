using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hız;
    int sayac = 0;
    public int toplanıcakobjesayısı;
    public Text sayacText;
    public Text OyunbittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hız);
      

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "toplanıcak")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            sayac++;
            Debug.Log(sayac);
            sayacText.text = "Syaç=" + sayac;
            if (sayac == toplanıcakobjesayısı)
            {

                OyunbittiText.text = "Oyun Bitti";
            }
        }
        


    }
}
