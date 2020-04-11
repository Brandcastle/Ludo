using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ludo.UI.Views
{
    public class ViewGameBoard : MonoBehaviour
    {
        [SerializeField]
        private PlayerYard[] allPlayerYards;
        [SerializeField]
        private Button backButton;

        private void Start()
        {
            if (GameManager.instance.CurrentGameType == GameType.OneToOne)
            {
                GameManager.instance.SetCurrentPlayerYards(new PlayerYard[2] { allPlayerYards[0], allPlayerYards[2] });
            }

            backButton.onClick.AddListener(HandleBackButtonClick);

            StartCoroutine(SetUp());
        }

        private IEnumerator SetUp()
        {
            if(GameManager.instance.CurrentGameType == GameType.OneToOne)
            {
                foreach (var yard in GameManager.instance.currentPlayerYards)
                {
                    yard.gameObject.SetActive(true);
                }
            }

            yield return null;
        }

        void HandleBackButtonClick()
        {
            SceneManager.LoadScene(Constants.SCENE_MAIN);
        }

    }
}
