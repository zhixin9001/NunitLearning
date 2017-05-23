using LogAn.Chapter5_New._5_4_1_Listener;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_4_1_Listener
{
  [TestFixture]
  public class EventRelatedTests
  {
    [Test]
    public void ctor_WhenViewIsLoaded_CallsViewRender()
    {
      var mockView = Substitute.For<IView>();
      var presenter = new Presenter(mockView);
      mockView.Loaded += Raise.Event<Action>();
      
      mockView.Received().Render(Arg.Is<string>(s => s.Contains("Hello World")));
    }
  }
}
