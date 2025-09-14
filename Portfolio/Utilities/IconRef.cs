// Utilities/IconHelper.cs
using static System.Net.WebRequestMethods;

namespace Portfolio.Utilities
{
    public static class IconRef
    {
        public static string GetIcon(string key) => key.ToLower() switch
        {
            "csharp" or "c#" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg",
            "cpp" or "c++" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/cplusplus/cplusplus-original.svg",
            "c" => "https://img.icons8.com/?size=512&id=40670&format=png",
            "dart" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/dart/dart-original.svg",
            "javascript" or "js" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-original.svg",
            "unity" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/unity/unity-original.svg",
            "flutter" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/flutter/flutter-original.svg",
            "react" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/react/react-original.svg",
            "blazor" => "https://upload.wikimedia.org/wikipedia/commons/d/d0/Blazor.png",
            "firebase" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/firebase/firebase-plain.svg",
            "azure" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/azure/azure-original.svg",
            "dotnet" or ".net" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg",
            "googlecloud" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/googlecloud/googlecloud-original.svg",
            "supabase" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/supabase/supabase-original.svg",
            "html" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original.svg",
            "css" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original.svg",
            "excel" => "https://img.icons8.com/color/96/microsoft-excel-2019--v1.png",
            "xcode" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/xcode/xcode-original.svg",
            "cmake" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/cmake/cmake-original.svg",
            "illustrator" => "https://upload.wikimedia.org/wikipedia/commons/f/fb/Adobe_Illustrator_CC_icon.svg",
            "photoshop" => "https://upload.wikimedia.org/wikipedia/commons/2/20/Photoshop_CC_icon.png",
            "premierepro" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/premierepro/premierepro-original.svg",
            "github" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/github/github-original.svg",
            "appstore" => "https://upload.wikimedia.org/wikipedia/commons/6/67/App_Store_%28iOS%29.svg",
            "googleplay" => "https://www.logo.wine/a/logo/Google_Play/Google_Play-Icon-Logo.wine.svg",
            "pycharm" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/pycharm/pycharm-original.svg",
            "python" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/python/python-original.svg",
            "opencv" => "https://raw.githubusercontent.com/devicons/devicon/master/icons/opencv/opencv-original.svg",
            "epic" => "https://upload.wikimedia.org/wikipedia/commons/3/31/Epic_Games_logo.svg",
            "admob" => "https://www.svgrepo.com/show/353801/google-admob.svg",
            _ => ""
        };
    }
}
