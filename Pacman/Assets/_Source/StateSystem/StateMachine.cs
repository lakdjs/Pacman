﻿using System;
using System.Collections.Generic;
using Core;

namespace StateSystem
{
    public class StateMachine: IStateMachine
    {
        private Dictionary<Type, AState> _states;
        private AState _currAState;
        
        public StateMachine(params AState[] states)
        {
            SetupStates(states);
        }
        
        public bool ChangeState<T>()
        {
            _currAState?.Exit();
            if (_states.ContainsKey(typeof(T)))
            {
                _currAState = _states[typeof(T)];
                _currAState.Enter();
                return true;
            }

            return false;
        }

        private void SetupStates(params AState[] states)
        {
            _states = new();
            foreach (var state in states)
            {
                _states.Add(state.GetType(),state);
            }
        }
    }
}