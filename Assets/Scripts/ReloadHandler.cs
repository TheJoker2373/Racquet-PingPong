using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadHandler : MonoBehaviour
{
    public static ReloadHandler Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}