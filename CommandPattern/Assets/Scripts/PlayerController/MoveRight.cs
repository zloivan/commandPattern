using UnityEngine;

namespace Assets.Scripts.PlayerController
{
    class MoveRight:ICommand
    {
        private readonly Player _player;
        private readonly Vector3 _previusPos;

        public MoveRight(Player player)
        {
            this._player = player;
            this._previusPos = player.transform.position;
        }

        public void Execute()
        {
            _player.MoveRight();
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
