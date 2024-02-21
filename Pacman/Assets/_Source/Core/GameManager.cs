using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class GameManager
    {
       /* [SerializeField] private Ghost[] ghosts;
        [SerializeField] private Pacman pacman;
        [SerializeField] private Transform pellets;
        [SerializeField] private Text gameOverText;
        [SerializeField] private Text scoreText;
        [SerializeField] private Text livesText;

        private int ghostMultiplier = 1;
        private int lives = 3;
        private int score = 0;

        public int Lives => lives;
        public int Score => score;

        private void Awake()
        {
            if (Instance != null) {
                DestroyImmediate(gameObject);
            } else {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        private void Start()
        {
            NewGame();
        }

        private void Update()
        {
            if (lives <= 0 && Input.anyKeyDown) {
                NewGame();
            }
        }

        private void NewGame()
        {
            SetScore(0);
            SetLives(3);
            NewRound();
        }

        private void NewRound()
        {
            gameOverText.enabled = false;

            foreach (Transform pellet in pellets) {
                pellet.gameObject.SetActive(true);
            }

            ResetState();
        }

        private void ResetState()
        {
            for (int i = 0; i < ghosts.Length; i++) {
                ghosts[i].ResetState();
            }

            pacman.ResetState();
        }

        private void GameOver()
        {
            gameOverText.enabled = true;

            for (int i = 0; i < ghosts.Length; i++) {
                ghosts[i].gameObject.SetActive(false);
            }

            pacman.gameObject.SetActive(false);*/
        }
    }