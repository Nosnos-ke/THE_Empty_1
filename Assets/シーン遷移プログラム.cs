using UnityEngine;
using UnityEngine.SceneManagement;

public class シーン遷移プログラム : MonoBehaviour
{ 

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}
