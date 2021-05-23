using System.Collections.Generic;

namespace ES.Core.ShareModel
{
    public static class AppStaticData
    {
        public static Dictionary<int, string> AppModules()
        {
            return new Dictionary<int, string>
            {
                {0, "Trang chủ"},
                {1, "Người dùng"}
            };
        }

        public static Dictionary<int, string> AppActions()
        {
            return new Dictionary<int, string>
            {
                {0, "All"},
                {1, "Chỉ đọc"},
                {2, "Lưu"},
                {3, "Xóa"}
            };
        }
    }
}