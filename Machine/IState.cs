﻿namespace Machine
{
    interface IState<KeyTypeTransition>
    {
        void SetNextState(KeyTypeTransition key, State<KeyTypeTransition> state);

        void AddNextState(State<KeyTypeTransition> state);

        void RemoveNextState(State<KeyTypeTransition> removeState);

        void ClearNextStates();
    }
}
