using System;
using System.Collections.Generic;
using UnityEngine;

namespace PelletSystem
{
    public class PelletList : MonoBehaviour
    {
        private Score _score;
        public List<Pellet> Pellets { get; private set; } = new List<Pellet>();

        public void Construct(Score score)
        {
            _score = score;
        }
        public void AddPelletInList(Pellet pellet)
        {
            Pellets.Add(pellet);
        }

        public void RemovePelletFromList(Pellet pellet)
        {
            
            if (Pellets.Contains(pellet))
            {
                Pellets.Remove(pellet);
                _score.AddScore(pellet.Cost);
                return;
            }

            throw new Exception("There is no such pellet!");
        }
    }
}
