using UnityEngine;
using System.Collections;

public class bullet_script : MonoBehaviour {
	private Vector2 wind_str;
    private pixel_control pixel_cnr;
    public GameObject explosion;

    // Use this for initialization
    void Start ()
    {
        wind_str = GameObject.Find("wind").GetComponent<wind>().wind_str;
        pixel_cnr = GameObject.Find("ground").GetComponent<pixel_control>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}


	void FixedUpdate(){
		gameObject.rigidbody2D.AddForce (wind_str);
		
		if (transform.position.y < -5) {
			Destroy(gameObject);
		}
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject explo = Instantiate(explosion) as GameObject;
        explo.transform.position = transform.position;
        /*
        Sprite sprite =  GetComponent<SpriteRenderer>().sprite;

        pixel_cnr.kill_by_sub_texture_shape_world_pos(transform.localPosition.x, transform.localPosition.y,
            (int)sprite.textureRect.width, (int)sprite.textureRect.height,
            (int)sprite.textureRect.x, (int)sprite.textureRect.y, sprite.texture);
        */
        Destroy(gameObject);

    }

}
