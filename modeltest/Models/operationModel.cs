namespace modeltest.Models
{
    public class operationModel
    {
        public string Action { get; set; }

        public string FtpAction { get; set; }

        public string RemoteDirectory { get; set; }

        public string FileFilter { get; set; }

        public string TransferType { get; set; }

        public int MaxFilesToRead { get; set; }
    }
}
