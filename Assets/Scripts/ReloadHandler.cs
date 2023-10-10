using UnityEngine.SceneManagement;
public static class ReloadHandler
{
    public static void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}