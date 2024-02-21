using System;
using UnityEngine;

namespace PelletSystem
{
    public class Pellet : MonoBehaviour
    {
        [field: SerializeField] public int Cost { get; private set; }
        private PelletList _pelletList;
        private void OnEnable()
        {
            _pelletList = FindFirstObjectByType<PelletList>();
            _pelletList.AddPelletInList(this);
        }

        public void RemovePellet()
        {
            _pelletList.RemovePelletFromList(this);
        }
    }
}
