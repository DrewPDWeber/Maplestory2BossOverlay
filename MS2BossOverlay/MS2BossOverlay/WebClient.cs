using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace MS2BossOverlay
{
    class WebClient
    {

        public static Bitmap GetBossImage(string bossname)
        {
            HttpWebResponse wresp = null;
            Stream mystream = null;
            Bitmap bmp = null;
            try
            {
                var wreq = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/ImSpare/MS2BossOverlay/master/images/" + bossname + ".png");
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch
            {
                // ignored happens if server has issues or something
            }
            finally
            {
                mystream?.Close();

                wresp?.Close();
            }
            return (bmp);
        }

        public static String GetBosses()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/ImSpare/MS2BossOverlay/master/boss.json");
            var response = (HttpWebResponse)request.GetResponse();
            var resStream = response.GetResponseStream();
            var count = 0;
            var buf = new byte[32];
            var sb = new StringBuilder();

            do
            {
                if (resStream != null) count = resStream.Read(buf, 0, buf.Length);

                if (count == 0) continue;
                var tempString = Encoding.ASCII.GetString(buf, 0, count);
                sb.Append(tempString);
            }
            while (count > 0);

            return sb.ToString();
        }
    }
}
