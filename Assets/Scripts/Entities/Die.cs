using UnityEngine;
using UnityEngine.UI;

namespace Ludo
{
    public class Die : MonoBehaviour
    {

        [SerializeField]
        Animator animator;

        [SerializeField]
        private Button dieRollButton;

        public bool RollAllowed{ get; set; }

        private void Awake()
        {
            RollAllowed = true;
            GameManager.instance.SetCurrentDie(this);
        }

        private void Start()
        {
            dieRollButton.onClick.AddListener(HandleDieButtonOnClick);
        }

        void HandleDieButtonOnClick()
        {
            if (RollAllowed)
            {
                RollAllowed = false;
                animator.SetInteger(Constants.DIE_NUMBER_INTEGER, Random.Range(1, 6));
                animator.SetTrigger(Constants.DIE_ROLL_TRIGGER);
            }
        }

        public void ResetDie()
        {
            animator.SetTrigger(Constants.DIE_RESET_TRIGGER);
            RollAllowed = true;
        }
    }
}