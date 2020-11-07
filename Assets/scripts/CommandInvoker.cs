using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker 
{
    //private staic to limit access but allow static functions
    private Stack<ICommand> CommandHistory = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        CommandHistory.Push(command);
        command.Execute();
    }

    public void UndoCommand()
    {
        //guard clause
        if (CommandHistory.Count <= 0)
        {
            return;
        }
        CommandHistory.Pop().Undo();
    }
}
