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
        Camera.main.transform.forward); //�� ����(ray)�� ī�޶���ġ���� forward�� ������.

        RaycastHit hit; //�������� �ε����� ������Ʈ�� ���°�

        //�������� �ε�ġ�°� ������~
        if (Physics.Raycast(ray, out hit, 20f)) //out=���, ������ �ε�ġ�°Ϳ� hit�� ����
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
            
        


        //// ���ڵ� ª��
        //TrevalA.SetActive(!TrevalA.activeSelf);
        //TrevalB.SetActive(!TrevalB.activeSelf);
    }
        }


        else //�ƹ��͵� �ε�ġ�°� ����.
        {
            recticle.fillAmount = 0;
        }

            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 1f);
        // origin�� �ڱ��ڽ��� ��ġ, �������� * ��������(����) , ���� , ���ӽð� ;
        }
    }


