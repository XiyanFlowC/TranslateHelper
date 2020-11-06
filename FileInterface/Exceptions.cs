using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInterface
{
    public class ParsingFailedException : Exception
    {
        public int ErrorCode { get; set; }
        public string Information { get; set; }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Information;
        }
        public ParsingFailedException()
        {
            ErrorCode = -1;
            Information = "Unknown";
        }

        public ParsingFailedException(int errCode)
        {
            ErrorCode = errCode;
            GetInformation();
        }

        public ParsingFailedException(int errCode, string info)
        {
            ErrorCode = errCode;
            Information = info;
        }

        private void GetInformation()
        {
            switch(ErrorCode)
            {
                case 0:
                    Information = "Normal";
                    break;
                case 1:
                    Information = "DataTypeInvalid";
                    break;
                default:
                    Information = "Undefined";
                    break;
            }
        }
    }

    public class FileFormatInvalidException : ParsingFailedException
    {
        public FileFormatInvalidException(int errCode)
        {
            ErrorCode = errCode;
            GetInformation();
        }

        void GetInformation()
        {
            switch (ErrorCode)
            {
                case 0:
                    Information = "Normal";
                    break;
                case 1:
                    Information = "Line count mismatch.";
                    break;
                case 2:
                    Information = "Unacceptable field count.";
                    break;
                default:
                    Information = "Undefined";
                    break;
            }
        }
    }
}
