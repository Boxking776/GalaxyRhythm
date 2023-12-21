using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGScroll : MonoBehaviour
{

    public RawImage _ImageObject;
    public float _XYIncrease;
    public float _MaxTweenDistance;

    // Update is called once per frame
    void Update()
    {
        if ((_ImageObject.uvRect.x > _MaxTweenDistance) | (_ImageObject.uvRect.x < -_MaxTweenDistance))
        {
            _XYIncrease = -_XYIncrease;
        };

        _ImageObject.uvRect = new Rect(
            _ImageObject.uvRect.position + new Vector2(_XYIncrease, _XYIncrease) * Time.deltaTime, 
            _ImageObject.uvRect.size
        );
    }
}
