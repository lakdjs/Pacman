using System;
using UnityEngine;

namespace LivesSystem
{
    public class Lives 
    {
        public int MaxLivesQuantity { get; private set; }
        public int CurrLivesQuantity { get; private set; }

        public event Action OnPacManDied;
        public event Action OnLifeDeleted;

        public Lives(int maxQuantity)
        {
            MaxLivesQuantity = maxQuantity;
            SetLives();
        }

        public void SetLives()
        {
            CurrLivesQuantity = MaxLivesQuantity;
        }
        
        public void DeleteLife()
        {
            if (CurrLivesQuantity > 1)
            {
                CurrLivesQuantity--;
                OnLifeDeleted?.Invoke();
                return;
            }
            OnPacManDied?.Invoke();
        }
    }
}
