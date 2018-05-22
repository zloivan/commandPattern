using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Assets.Scripts.CommandManager
{
    class CommandManager
    {
        private List<ICommand> _commands;
        private int _currentCom;
        private int _targetCom; //отсечка

        public CommandManager()
        {
            _commands  = new List<ICommand>();
            _currentCom = -1;
            _targetCom = -1;
        }

        public void SetCommand(ICommand command)
        {
            _ClearCommands();
            _commands.Add(command);
            _targetCom = _commands.Count - 1;
        }

        private void _ClearCommands()
        {
            int lastIndex = _commands.Count - 1;

            if (_targetCom < lastIndex)
            {
                _commands.RemoveRange(_targetCom + 1, lastIndex - _targetCom);
            }
        }

        public bool ExecuteCommand()
        {
            if (_commands.Count > 0 && _currentCom != _targetCom)
            {
                _currentCom++;
                _commands[_currentCom].Execute();
                return true;
            }

            return false;
        }

        public bool UndoCommand()
        {
            if (_commands.Count > 0 && _currentCom > -1)
            {
                _commands[_currentCom].UnExecute();
                _currentCom--;
                _targetCom = _currentCom;
            }

            return _currentCom > -1;
        }

        public bool RedoCommand()
        {
            if (_commands.Count > 0 && _currentCom < _commands.Count - 1)
            {
                _currentCom++;
                _commands[_currentCom].ReExecute();
                _targetCom = _currentCom;
            }

            return _currentCom != _commands.Count - 1;
        }
    }
}
