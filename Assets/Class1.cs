using UnityEngine;

public class QuitManager : MonoBehaviour
{
    // InspectorからダイアログのUIパネルを割り当てる
    [SerializeField] private GameObject confirmDialogPanel;

    // 最初の「終了」ボタンを押した時に呼ばれる
    public void ShowConfirmDialog()
    {
        confirmDialogPanel.SetActive(true);
    }

    // ダイアログの「いいえ」を押した時に呼ばれる
    public void HideConfirmDialog()
    {
        confirmDialogPanel.SetActive(false);
    }

    // ダイアログの「はい」を押した時に呼ばれる（実際の終了処理）
    public void QuitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}