using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;
    Sequence Sequence;

    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);
        //transform.DORotate(new Vector3(0, 0, 180), 2);
       //transform.DOScale(new Vector3(3,3,3), 2);

        //Sequence = DOTween.Sequence();
        //Sequence.Append(transform, DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //Sequence.Append(transform, DORotate(new Vector3(0, 0, 180), 2). OnComplete(SequenceEnd));
        //Sequence.Append(transform, DOScale(new Vector3(3, 3, 3), 2);
        //Sequence.SetLoops(-1, LoopType.Yoyo);

    }

    void SequenceEnd()
    {
        Debug.Log("ȸ���Ϸ�");
    }
    void EndPunch()
    {
        isPunch = false;

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isPunch == false)
            {
                isPunch = true;
                
                     transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            }
        }
    }
}
