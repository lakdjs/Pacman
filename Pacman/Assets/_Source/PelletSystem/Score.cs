using System;
using UnityEngine;

namespace PelletSystem
{
    public class Score
    {
        public const int StartValue = 0;
        private int _maxPelletValue;
        private int _currPelletValue;
        private const int EndValue = 0;
        private  int _maxScoreValue;
        public int ScoreValue { get; private set; } 

        public event Action OnMaxPellet; 
        public event Action<int> OnScoreChange;

        public Score(int maxPelletValue)
        {
            _maxPelletValue = maxPelletValue;
            _currPelletValue = _maxPelletValue;
        }
        
        public void ResetScore()
        {
            ScoreValue = EndValue;
            OnScoreChange?.Invoke(ScoreValue);
        }
        public void SetUpScore()
        {
            Debug.Log("1");
            ScoreValue = StartValue;
            OnScoreChange?.Invoke(ScoreValue);
        }

        public void AddPelletScore(int adding)
        {
            Debug.Log(ScoreValue);
            ScoreValue += adding;
            _currPelletValue += adding;
            OnScoreChange?.Invoke(ScoreValue);
            if (_currPelletValue >= _maxPelletValue)
            {
                OnMaxPellet?.Invoke();
            }
        }
        public void AddScore(int adding)
        {
            Debug.Log(ScoreValue);
            ScoreValue += adding;
            OnScoreChange?.Invoke(ScoreValue);
        }
    }
}