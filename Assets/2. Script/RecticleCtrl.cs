using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecticleCtrl : MonoBehaviour
{
    public Image recticle;
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
        Camera.main. transform. forward) ;

        RaycastHit hit; //�������� �ε����� ������Ʈ�� ���°�
       
        //�������� �ε�ġ�°� ������~
        if(Physics.Raycast(ray,out hit, 20f))
        {
            recticle.fillAmount += Time.deltaTime;

            if( recticle.fillAmount == 1)
            {
                TrevalA.SetActive(false);
                TrevalB.SetActive(true);
            }
        }

        else //�ƹ��͵� �ε�ġ�°� ����.
        {
            recticle.fillAmount = 0;
        }

        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 1f);
    }
}