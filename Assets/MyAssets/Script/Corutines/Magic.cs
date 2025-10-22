using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour
{
    [SerializeField] private Image _icoldownColor,_icoldownSize,_icoldownRotate;
    [SerializeField] private GameObject _slave;
    [SerializeField] private SpriteRenderer _slaveImage;
    [SerializeField] private int _coldownColor,_coldownSize,_coldownRotate;
    private bool _isCooldownColor = true ,_isCooldownSize = true,_isCooldownRotate = true;
    public void Color()
    {
        if (_isCooldownColor == false) return;
        _isCooldownColor = false;
        _slaveImage.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f),1f);
        StartCoroutine(ColdownVisual(_icoldownColor,_coldownColor,0));
        print("Color");
    }

    public void Rotate()
    {
        if (_isCooldownRotate == false) return;
        _isCooldownRotate = false;
        _slave.transform.localRotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        StartCoroutine(ColdownVisual(_icoldownRotate, _coldownRotate, 1));
    }

    public void Size()
    {
        if (_isCooldownSize == false) return;
        _isCooldownSize = false;
        _slave.transform.localScale = new Vector3(Random.Range(1,5),Random.Range(1,5),Random.Range(1,5));
        StartCoroutine(ColdownVisual(_icoldownSize,_coldownSize,2));        
    }

    private IEnumerator ColdownVisual(Image Fillsome,int coldown,int type)
    {
        for (float i = 0; i <= coldown; i += Time.deltaTime) {
            Fillsome.fillAmount = i / coldown;
            yield return null;
        }

        switch (type)
        {
            case 0:
                _isCooldownColor = true;
                break;
            case 1:
                _isCooldownSize = true;
                break;
            case 2:
                _isCooldownRotate = true;
                break;
        }
    }
}
