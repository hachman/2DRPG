using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public int sceneBuildinex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("trigger Entered");

        if (other.tag == "Player")
        {
            print("switching scene to " + sceneBuildinex);
            SceneManager.LoadScene(sceneBuildinex, LoadSceneMode.Single);
        }
    }
}
