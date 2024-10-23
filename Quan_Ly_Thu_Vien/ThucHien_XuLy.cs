using Quan_Ly_Thu_Vien.DuLieu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien
{
    public class ThucHien_XuLy
    {
        public static List<ThongTin_NguoiMuon> DanhSach_NguoiMuon = new List<ThongTin_NguoiMuon>();

        public static string DuongDan_MacDinh = "Quan_Ly_ThongTin_NguoiMuon.dk";

        public static bool ReadBinaryFile()
        {
            try
            {
                FileStream fs = new FileStream(DuongDan_MacDinh, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DanhSach_NguoiMuon = (List<ThongTin_NguoiMuon>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool WriteBinaryFile()
        {
            try
            {
                FileStream fs = new FileStream(DuongDan_MacDinh, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DanhSach_NguoiMuon);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
