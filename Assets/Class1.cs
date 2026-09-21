using UnityEngine;

public class QuitManager : MonoBehaviour
{
    // ボタンが押されたときに呼ばれるメソッド
    public void QuitApp()
    {
#if UNITY_EDITOR
        // Unityエディタのプレイモードを終了する
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // ビルドされたアプリケーションを終了する
        Application.Quit();
#endif
    }
}