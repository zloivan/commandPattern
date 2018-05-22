using UnityEngine;

namespace Assets.Scripts.PlayerController
{
    class MoveUp:ICommand
    {
        private readonly Player _player;
        private readonly Vector3 _previusPos;

        public MoveUp(Player player)
        {
            this._player = player;
            this._previusPos = player.transform.position;
        }

        public void Execute()
        {
            _player.MoveUp();
        }

        public void UnExecute()
        {
            _player.transform.position = _previusPos;
        }

        public void ReExecute()
        {
            Execute();
        }
    }
}
