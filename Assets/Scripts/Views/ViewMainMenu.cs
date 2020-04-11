using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ludo.UI.Views
{
    public class ViewMainMenu : MonoBehaviour
    {
        [SerializeField]
        private Button StartOneToOne;

        void Start()
        {
            StartOneToOne.onClick.AddListener(HandleOneToOneButtonClick);
        }

        void HandleOneToOneButtonClick()
        {
            SceneManager.LoadScene(Constants.SCENE_GAME);
        }
    }
}
