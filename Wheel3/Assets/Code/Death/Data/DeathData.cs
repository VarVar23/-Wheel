using UnityEngine;

namespace Sergey
{
    public class DeathData
    {
        public AudioClip[] AudioClipsDeathPlayer { get; private set; }
        public DeathData(DeathPlayerSO deathPlayerSo)
        {
            //AudioClipsDeathPlayer = deathPlayerSo._AudioClipsDeathPlayer;
        }
    }
}