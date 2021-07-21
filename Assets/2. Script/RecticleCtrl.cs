using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecticleCtrl : MonoBehaviour
{
    public Image recticle;
    //public Image recticle2 ;

    public GameObject TrevalA;
    public GameObject TrevalB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position,
        Camera.main.transform.forward); //새 광선(ray)가 카메라위치에서 forward로 나간다.

        RaycastHit hit; //레이저랑 부딪히는 오브젝트가 들어가는곳

        //레이저에 부딪치는게 있으면~
        if (Physics.Raycast(ray, out hit, 20f)) //out=출력, 광선이 부딪치는것에 hit에 들어간다
        {
            recticle.fillAmount += Time.deltaTime;

            if (recticle.fillAmount == 1)
            {
                if (TrevalA.activeSelf == true)
                {
                    TrevalA.SetActive(false);
                    TrevalB.SetActive(true);
                }

            }
            else if (TrevalA.activeSelf == false)
            {
                TrevalA.SetActive(true);
                TrevalB.SetActive(false);
            
        


        //// 위코드 짧게
        //TrevalA.SetActive(!TrevalA.activeSelf);
        //TrevalB.SetActive(!TrevalB.activeSelf);
    }
        }


        else //아무것도 부딪치는게 없다.
        {
            recticle.fillAmount = 0;
        }

            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 1f);
        // origin이 자기자신의 위치, 광선방향 * 광선범위(길이) , 색상 , 지속시간 ;
        }
    }


