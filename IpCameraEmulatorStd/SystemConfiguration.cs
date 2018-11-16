using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using Emulator;

namespace IpCameraEmulatorStd
{
  public class SystemConfiguration
  {
    private const string ConfigurationFileExtension = @".cfg";

    private string _AppConfigFolder = Environment.GetFolderPath(
      Environment.SpecialFolder.CommonApplicationData) + @"\IpCameraEmulator\";

    private Point _WindowLocation;
    private Size _WindowSize;
    private FormWindowState _AppWIndowState;
    private bool _ShowSystemResourceUsage;
    private Collection<EmulatorChannel> _Channels;

    private bool _AppSettingsChanged = false;
    public string ConfigurationFileName { get; set; }

    // --------------------------------------------------------

    #region Public Properties

    public Point WindowLocation
    {
      get { return _WindowLocation; }
      set
      {
        _WindowLocation = value;
        _AppSettingsChanged = true;
      }
    }

    public Size WindowSize
    {
      get { return _WindowSize; }
      set
      {
        _WindowSize = value;
        _AppSettingsChanged = true;
      }
    }

    public FormWindowState AppWIndowState
    {
      get { return _AppWIndowState; }
      set
      {
        _AppWIndowState = value;
        _AppSettingsChanged = true;
      }
    }

    public bool ShowSystemResourceUsage
    {
      get { return _ShowSystemResourceUsage; }
      set
      {
        _ShowSystemResourceUsage = value;
        _AppSettingsChanged = true;
      }
    }

    public Collection<EmulatorChannel> Channels
    {
      get { return _Channels; }
      set
      {
        _Channels = value;
        _AppSettingsChanged = true;
      }
    }

    #endregion

    // ------------------------------------------------------------------

    #region Public Methods

    public bool Load()
    {
      XmlSerializer serializer = null;
      FileStream fileStream = null;
      bool fileExists = false;

      try
      {
        // Create an XmlSerializer for the SystemConfiguration type.
        serializer = new XmlSerializer(typeof(SystemConfiguration));
        FileInfo fi = new FileInfo(_AppConfigFolder + ConfigurationFileName + ConfigurationFileExtension);
        // If the config file exists, open it.
        if (fi.Exists)
        {
          fileStream = fi.OpenRead();
          // Create a new instance of the SystemConfiguration by deserializing the config file.
          SystemConfiguration appSettings = (SystemConfiguration)serializer.Deserialize(fileStream);
          // Assign property values to this instance of the SystemConfiguration class.
          _WindowLocation = appSettings.WindowLocation;
          _WindowSize = appSettings.WindowSize;
          _AppWIndowState = appSettings.AppWIndowState;
          _ShowSystemResourceUsage = appSettings.ShowSystemResourceUsage;
          _Channels = appSettings.Channels;
          fileExists = true;
        }
        else
        {
          // Create default config.
          _WindowLocation = new Point(0, 0);
          _WindowSize = new Size(800, 600);
          _AppSettingsChanged = true;
          _ShowSystemResourceUsage = false;
          _Channels = new Collection<EmulatorChannel>();
          fileExists = Save();
        }
      }
      catch
      {
        throw;
      }
      finally
      {
        if (fileStream != null)
        {
          fileStream.Close();
        }
      }
      return fileExists;
    }

    public bool Save()
    {
      if (_AppSettingsChanged)
      {
        StreamWriter writer = null;
        XmlSerializer serializer = null;

        try
        {
          if (!Directory.Exists(_AppConfigFolder))
          {
            Directory.CreateDirectory(_AppConfigFolder);
          }

          // Create an XmlSerializer for the SystemConfiguration type.
          serializer = new XmlSerializer(typeof(SystemConfiguration));
          writer = new StreamWriter(_AppConfigFolder + ConfigurationFileName + ConfigurationFileExtension, false);
          // Serialize this instance of the SystemConfiguration class to the config file.
          serializer.Serialize(writer, this);
        }
        catch
        {
          throw;
        }
        finally
        {
          if (writer != null)
          {
            writer.Close();
          }
        }
      }
      return _AppSettingsChanged;
    }

    #endregion

    // ------------------------------------------------------------------

    public SystemConfiguration()
    {
    }

    public SystemConfiguration(string configurationFileName)
    {
      ConfigurationFileName = configurationFileName;
    }

  }
}
