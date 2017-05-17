using System;

namespace LogAn
{
  public class LogAnalyzer
  {
    public bool WasLastFileNameValid { get; set; }

    public bool IsValidLogFileName(string fileName)
    {
      IExtensionManger mgr = new FileExtensionManager();
      return mgr.IsValid(fileName);
    }

    public class FileExtensionManager : IExtensionManger
    {
      public bool IsValid(String fileName)
      {
        if (string.IsNullOrEmpty(fileName))
        {
          throw new ArgumentException("filename has to be provided");
        }
        if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
        {
          return false;
        }
        return true;
      }
    }

    public interface IExtensionManger
    {
      bool IsValid(string fileName);
    }

    public class StubExtensionManager : IExtensionManger
    {
      public bool IsValid(string fileName)
      {
        return true;
      }
    }

  }
}
