using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Controller
{
    public static class ConexaoFtp
    {
        public static bool TestarConexao(string usuario, string password)
        {
            try
            {
                var host = "ftpupper.uppertools.inf.br";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = false; // useful when only to check the connection.         
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(usuario, password);
                request.GetResponse();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
