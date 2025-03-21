using UnityEngine;

public class securityCamera : MonoBehaviour
{
    GameManager gm;
    Camera myCam;

    void Awake()
    {
        myCam = GetComponent<Camera>();
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = myCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.tag == "Worker")
                {
                    gm.companyRep += Random.Range(10,15);
                }
                
            }
        }
    }
}
