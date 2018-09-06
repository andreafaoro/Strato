using System;
using System.Windows.Forms;
using Strato.Common;

namespace Strato.ActionsProvider
{
  public class ActionMove : IActionProvider
  {
    private int state = 0;

    public void Abort()
    {
      state = 0;
    }

    public void FireAction()
    {
      state = 1;
    }

    public void KeyPressed(Keys[] keys)
    {
      switch (state) {
        case 1:
          // State 0:
          break;
        case 2:
          break;
      }
    }
  }
}
