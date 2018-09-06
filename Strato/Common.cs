using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strato.Common
{
  public class Coord
  {
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public float Elev { get; set; }

    public void ToGeographicalCoords(out double lat, out double lon)
    {
      lat = Math.Atan(Z / Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)));
      lon = Math.Atan(Y / X);
    } 
  }

  /// <summary>
  /// Base interface for all primitives in the program. A primitive can be a point,
  /// a line or a spline. Built for a long term development evolution
  /// </summary>
  public interface IPrimitive
  {
    Coord BasePoint { get; set; }
  }

  /// <summary>
  /// Base interface for actions. An action is an operatio that can be done in the
  /// program environment, i.e point move, new line, isocline creation, etc.
  /// </summary>
  public interface IActionProvider
  {
    void KeyPressed(Keys[] keys);
    void FireAction();
    void Abort();
  }    


  /// <summary>
  /// Base interface for graphic intefaces manager.
  /// </summary>
  public interface IInterfaceProvider
  {
    int SelectedCount { get; }
    IPrimitive[] Selected { get; }

    void EnableSelect(bool enable);
  }
}
