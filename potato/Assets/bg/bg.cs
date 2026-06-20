using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public List<Texture2D> backgroundList = new List<Texture2D>();
    SpriteRenderer rendererComponent;
    public float animationTimer = 0.1f;

    void Start()
    {
        rendererComponent = GetComponent<SpriteRenderer>();
        StartCoroutine(Anim());
    }

    IEnumerator Anim()
    {
        if (backgroundList == null || backgroundList.Count == 0) yield break;

        while (true)
        {
            for (int i = 0; i < backgroundList.Count; i++)
            {
                if (backgroundList[i] != null)
                {
                    Texture2D tex = backgroundList[i];

                    rendererComponent.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                }
                yield return new WaitForSeconds(animationTimer);
            }
        }
    }
}



