using UnityEngine;

public class BaseBlockScript : MonoBehaviour {

    public float velocidade;
    public float limiteEsquerdo, limiteDireito;
    
	// Update is called once per frame
	void Update () {
        Mover();
    }

    void Mover()
    {

        // Mover
        var move_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(move_x, 0.0f, 0.0f);

        // Wrap
        if (transform.position.x < limiteEsquerdo || transform.position.y > limiteDireito)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }
    }
}
