using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    GameManager gm;

    [Header("MAKE PLAYER CAM INDEX 0 ALWAYS")]
    public GameObject[] cameras;
    public Camera activeCam;
    public int currentIndex;

    void Start()
    {
        //camManager = GetComponent<CameraManager>();
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        activeCam = cameras[0].GetComponent<Camera>();
        currentIndex = 0;
    }
    void Update()
    {
        activeCam = cameras[currentIndex].GetComponent<Camera>();
        Ray ray = activeCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && currentIndex == 0)
        {
            if (Input.GetMouseButtonDown(0) && gm.energy > 0)
            {
                print(hit.collider.name);

                if (hit.collider.name == "Monitor (1)")
                {
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(true);
                    gm.energy -= 15;
                    currentIndex = 1;
                }
                if (hit.collider.name == "Monitor (2)")
                {
                    cameras[0].SetActive(false);
                    cameras[2].SetActive(true);
                    gm.energy -= 15;
                    currentIndex = 2;
                }
                if (hit.collider.name == "Monitor (3)")
                {
                    cameras[0].SetActive(false);
                    cameras[3].SetActive(true);
                    gm.energy -= 15;
                    currentIndex = 3;
                }
                if (hit.collider.name == "Monitor (4)")
                {
                    cameras[0].SetActive(false);
                    cameras[4].SetActive(true);
                    gm.energy -= 15;
                    currentIndex = 4;
                }
            }
        }

        //Previous Camera
        if (Input.GetKeyUp(KeyCode.A) && gm.energy >= 10)
        {
            if (currentIndex > 0) {
                cameras[currentIndex].SetActive(false);
                cameras[currentIndex - 1].SetActive(true);
                currentIndex = currentIndex - 1;
                gm.energy -= 10;
            }
            else
            {
                cameras[0].SetActive(false);
                cameras[cameras.Length - 1].SetActive(true);
                currentIndex = cameras.Length - 1;
                gm.energy -= 10;
            }
        }
        //Next Camera
        if (Input.GetKeyUp(KeyCode.D) && gm.energy >= 10)
        {
            if (currentIndex < cameras.Length - 1)
            {
                cameras[currentIndex].SetActive(false);
                cameras[currentIndex + 1].SetActive(true);
                currentIndex = currentIndex + 1;
                gm.energy -= 10;
            }
            else
            {
                cameras[currentIndex].SetActive(false);
                cameras[0].SetActive(true);
                currentIndex = 0;
                gm.energy -= 10;
            }
        }
        //Back to security room
        if (Input.GetKey(KeyCode.Escape))
        {
            cameras[currentIndex].SetActive(false);
            cameras[0].SetActive(true);
            currentIndex = 0;
        }
    }
}