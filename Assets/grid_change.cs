using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid_change : MonoBehaviour
{
    public GameObject cube_;
    public SpriteRenderer sprite_;

    private void Awake()
    {
        sprite_ = cube_.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        var texture_ = Resources.Load<Texture2D>("grid_texture/x");
        float pixelsUnit = sprite_.sprite.pixelsPerUnit;
        float size_ = sprite_.sprite.rect.width;
        Sprite new_sprite = Sprite.Create(texture_,new Rect(0,0,texture_.width,texture_.height), new Vector2(0.5f,0.5f),pixelsUnit);
        sprite_.sprite = new_sprite;
        transform.localScale = new Vector3(size_ / texture_.width, size_ / texture_.height, 0f);
        
        //sprite_.sprite.texture = texture_;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
