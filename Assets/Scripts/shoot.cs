using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public int max = 20;
    public int bulletInWeapon = 20;
    public Transform weapon;
    public GameObject bullet;
    public GameObject exploson;
    private Animator anim;
    public AudioSource soundShoot;
    public TextMeshProUGUI countText;

    void Start()
    {
        anim = GetComponent<Animator>();
    
        SetCountBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (max > 0)
        {

      
        if (Input.GetButtonDown("Fire1"))
        {
            DoShoot();
                anim.SetBool("isShooting", true);
               soundShoot.Play();
            }
            else
            {
                anim.SetBool("isShooting", false);
               
            }
           


        }
     
    }

    private void DoShoot()
    {
        Instantiate(bullet, weapon.position, weapon.rotation);
        Instantiate(exploson, weapon.position, weapon.rotation);
      
        max = max - 1;
        SetCountBullet();

    }

    void SetCountBullet()
    {
        countText.text = max + "/"+bulletInWeapon;
    }

    public void reloadWeapon(int reload)
    {
        if (max <= 15)
        {
            max += 5;
            SetCountBullet();
        }
        else
        {

            int bulletStay =bulletInWeapon - max;
            max += bulletStay;
            SetCountBullet();

        }
    }
}
