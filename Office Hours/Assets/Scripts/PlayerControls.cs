using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //CameraManager camManager;
    GameManager gm;
    public GameObject playerCam;
    public GameObject cam01;
    public GameObject cam02;
    public GameObject cam03;
    public GameObject cam04;

    void Start()
    {
        //camManager = GetComponent<CameraManager>();
        //gm = GetComponent<GameManager>();
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                print(hit.collider.name);

                if (hit.collider.name == "Monitor (1)")
                {
                    playerCam.SetActive(false);
                    cam01.SetActive(true);
                    gm.energy -= 15;
                }
                if (hit.collider.name == "Monitor (2)")
                {
                    playerCam.SetActive(false);
                    cam02.SetActive(true);
                    gm.energy -= 15;
                }
                if (hit.collider.name == "Monitor (3)")
                {
                    playerCam.SetActive(false);
                    cam03.SetActive(true);
                    gm.energy -= 15;
                }
                if (hit.collider.name == "Monitor (4)")
                {
                    playerCam.SetActive(false);
                    cam04.SetActive(true);
                    gm.energy -= 15;
                }
            }
        }
    }
}
