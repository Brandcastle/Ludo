using UnityEngine;

namespace Ludo
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public GameType CurrentGameType { get; set; }

        public PlayerYard[] currentPlayerYards { get; private set; }

        public Die die { get; private set; }

        private GameManager() { }

        void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(this);

            instance = this;
        }

        public void SetCurrentPlayerYards(PlayerYard[] playerYards)
        {
            currentPlayerYards = playerYards;
        }

        public void SetCurrentDie(Die die)
        {
            this.die = die;
        }

        private void OnDestroy()
        {
            if (Equals(instance))
            {
                instance = null;
            }
        }
    }
}
