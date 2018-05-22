using UnityEngine;

namespace Assets.Scripts.PlayerController
{
    class MoveLeft:ICommand
    {
        private readonly Player _player;
        private readonly Vector3 _previusPos;

        public MoveLeft(Player player)
        {
            this._player = player;
            this._previusPos = player.transform.position;
        }

        public void Execute()
        {
            _player.MoveLeft();
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
