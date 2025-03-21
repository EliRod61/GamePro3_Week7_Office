using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    GameManager gm;

    public GameObject previousCam;
    public GameObject nextCam;
    public GameObject playerCam;
    public GameObject currentCam;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
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

        //Previous Camera
        if (Input.GetKey(KeyCode.A))
        {
            currentCam.SetActive(false);
            previousCam.SetActive(true);
            //currentCam.SetActive(false);
        }
        //Next Camera
        else if (Input.GetKey(KeyCode.D))
        {
            currentCam.SetActive(false);
            nextCam.SetActive(true);
            //currentCam.SetActive(false);
        }
        //Back to security room
        else if (Input.GetKey(KeyCode.Escape))
        {
            currentCam.SetActive(false);
            playerCam.SetActive(true);
            //currentCam.SetActive(false);
        }
    }
}
