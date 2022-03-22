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
    private Animator anim;
    public GameObject soundShoot;
    public TextMeshProUGUI countText;

    void Start()
    {
        anim = GetComponent<Animator>();
        soundShoot.SetActive(false);
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
                soundShoot.SetActive(true);
            }
            else
            {
                anim.SetBool("isShooting", false);
               
            }
           


        }
        soundShoot.SetActive(false);
    }

    private void DoShoot()
    {
        Instantiate(bullet, weapon.position, weapon.rotation);
      
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
