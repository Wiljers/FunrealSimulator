using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FlipDetector : MonoBehaviour {
    [SerializeField]
    private GameObject ground;

    [SerializeField]
    Canvas canvas;
    private bool flipped = false;

    [SerializeField]
    GameObject coffin;

    [SerializeField]
    private Grave m_Gravescrip;

    [SerializeField]
    string levelName;

    [SerializeField]
    Animator RestartButton;

    // Use this for initialization
    void Start () {

       
	
	}
	
	// Update is called once per frame
	void Update () {

       
           
                if (Input.GetButtonDown("Restart"))
                { SceneManager.LoadScene(levelName);}
        
    }

    void OnTriggerEnter(Collider c_collider)
    {
        print("GG M8");
        if (c_collider.gameObject == ground)
        {


            StartCoroutine(FlipTimer());

     
        }

    }

   void OnTriggerExit(Collider c_CoffinCollider)
    {
        if (c_CoffinCollider.gameObject == coffin)
            StartCoroutine(FlipTimer());
    } 

    IEnumerator FlipTimer()
    {
        yield return new WaitForSeconds(1);

        if (m_Gravescrip.isDelivered == false)
        {  canvas.gameObject.SetActive(true);
            RestartButton.SetTrigger("Crashed");

        
         flipped = true; }

    }
}
