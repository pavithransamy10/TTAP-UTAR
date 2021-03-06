﻿using System;
using System.Diagnostics;

namespace Time_Table_Arranging_Program.Pages.Login {
    public class UrlProvider {
        public string DownloadLink => "https://goo.gl/5XBxHV";
        public string GitHubLink => "https://github.com/wongjiahau/TTAP-UTAR";
        public string FeedbackFormUrl => "https://goo.gl/forms/qKdc6EVGbxspoTaS2";
        public string ReportBugUrl => "https://goo.gl/forms/4PJupNgRTEyGGTCN2";

        public string HelpGifUrl =>
            "https://raw.githubusercontent.com/wongjiahau/TTAP-UTAR/master/TTAP_Tutorial_v2.gif";

        public string ReadMeUrl => "https://github.com/wongjiahau/TTAP-UTAR/blob/master/README.md";
        public string LoginPageUrl => "https://unitreg.utar.edu.my/portal/courseRegStu/login.jsp";

        public string CourseTimetablePreviewUrl =>
            "https://unitreg.utar.edu.my/portal/courseRegStu/schedule/masterSchedule.jsp";

        public string KaptchaUrl => "https://unitreg.utar.edu.my/portal/Kaptcha.jpg";
        public string TestServerUrl => "http://localhost/ttap_testdata/";
        public string EndUrl => "http://0.0.0.0/";

        public bool IsLoginFailed(string url) {
            string InvalidIdOrPasswordUrl =
                "https://unitreg.utar.edu.my/portal/courseRegStu/login.jsp?message=loginError";
            string InvalidCaptchaUrl =
                "https://unitreg.utar.edu.my/portal/courseRegStu/login.jsp?message=invalidSecurity";
            return
                url.Contains(InvalidCaptchaUrl) ||
                url.Contains(InvalidIdOrPasswordUrl);
        }

        public bool IsAtLoginPage(string url) {
            return url.Split(new[] {"//"}, StringSplitOptions.None)[1] ==
                   LoginPageUrl.Split(new[] {"//"}, StringSplitOptions.None)[1];
        }
    }

    public class UrlOpener {
        public static void OpenLinkInBrowser(string url) {
            Process.Start(new ProcessStartInfo(url));
            
        }
    }


}