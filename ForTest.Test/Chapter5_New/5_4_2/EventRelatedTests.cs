using LogAn.Chapter5_New._5_4_2;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Test.Chapter5_New._5_4_2
{
  [TestFixture]
  public class EventRelatedTests
  {
    [Test]
    public void ctor_WhenViewIsLoaded_CallsViewRender()
    {
      var stubView = Substitute.For<IView>();
      var mockLogger = Substitute.For<ILogger>();
      var presenter = new Presenter(stubView,mockLogger);
      stubView.ErrorOccured += Raise.Event<Action<string>>("fake error");

      mockLogger.Received().LogError(Arg.Is<string>(s=>s.Contains("fake error")));
    }
  }
}
