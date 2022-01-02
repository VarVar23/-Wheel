using Code.ScriptableObject;

namespace Code.Model
{
    public class PlayerData
    {
        
        private ForceForPlayer _forceToSpeedPlayer;

        public ForceForPlayer ForceToSpeedPlayer
        {
            get => _forceToSpeedPlayer;
            set => _forceToSpeedPlayer = value;
        }


        public PlayerData(ForceForPlayer force)
        {
            ForceToSpeedPlayer = force;
        }
    }
}