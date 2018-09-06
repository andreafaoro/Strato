using Strato.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strato.InterfaceProvider
{
  class Class1 : IInterfaceProvider
  {
    int IInterfaceProvider.SelectedCount => throw new NotImplementedException();

    IPrimitive[] IInterfaceProvider.Selected => throw new NotImplementedException();

    void IInterfaceProvider.EnableSelect(bool enable)
    {
      throw new NotImplementedException();
    }

  }
}
