using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.Chapter3._3_4_6_2_Virtual
{
  public class ExtensionManagerFactory
  {
    static IExtensionManager customManager = null;

    public static IExtensionManager Create()
    {
      if (customManager != null) return customManager;
      return new FileExtensionManager();
    }

    public static void SetManager(IExtensionManager mgr)
    {
      customManager = mgr;
    }
  }
}
