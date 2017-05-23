using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_4_3_Trigger
{
  [TestFixture]
  public class EventFiringManual
  {
    [Test]
    public void FireEvent()
    {
      bool loadFired = false;
      SomeView view = new SomeView();
      view.Loaded += delegate
                                  {
                                    loadFired = true;
                                  };
      view.DoShomething();

      Assert.IsTrue(loadFired);
    }
  }
}
