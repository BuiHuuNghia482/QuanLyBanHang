using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_LayDuLieu
    {
        static string chuoi_ket_noi = @"Data Source=DESKTOP-K4Q6B8N;Initial Catalog=QLBH_CK;Integrated Security=True";
        static string KNoiRestore = @"Data Source=DESKTOP-K4Q6B8N;Initial Catalog=QLBH_CK;Integrated Security=True";
        //lay du lieu bang : input la ten bang
        public static DataTable LayDuLieuTuBang(string tenBang)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Câu truy vấn
            string sql = "Select * from " + tenBang;
            //Tạo bộ chuyển đổi dữ liệu
            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);
            //Bảng chứa dữ liệu
            DataTable bang = new DataTable();
            //Đổ dữ liệu vào
            bo_chuyen_doi.Fill(bang);
            return bang;
        }
        //lay du lieu bang : input la cau truy van
        public static DataTable LayDuLieuSQL(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Tạo bộ chuyển đổi dữ liệu
            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);
            //Bảng chứa dữ liệu
            DataTable bang = new DataTable();
            //Đổ dữ liệu vào
            bo_chuyen_doi.Fill(bang);
            return bang;
        }
        //insert csdl
        public static bool InsertSQL(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi);
            ket_noi.Open();
            SqlCommand cmd = new SqlCommand(sql, ket_noi);
            int n = cmd.ExecuteNonQuery();
            ket_noi.Close();
            //so dong anh huong 
            if (n > 0)
            { // cap nhat thanh  cong
                return true;
            }
            return false;//cap nhat that bai;
        }
        //update csdl
        public static bool UpdateSQL(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi);
            ket_noi.Open();
            SqlCommand cmd = new SqlCommand(sql, ket_noi);
            int n = cmd.ExecuteNonQuery();
            ket_noi.Close();
            //so dong anh huong 
            if (n > 0)
            { // cap nhat thanh  cong
                return true;
            }
            return false;//cap nhat that bai;
        }
        //delete csdl
        public static bool DeleteSQL(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi);
            ket_noi.Open();
            SqlCommand cmd = new SqlCommand(sql, ket_noi);
            int n = cmd.ExecuteNonQuery();
            ket_noi.Close();
            //so dong anh huong 
            if (n > 0)
            { // cap nhat thanh  cong
                return true;
            }
            return false;//cap nhat that bai;
        }
        //backup 
        public static bool Backup(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            int so_dong_anh_huong = lenh.ExecuteNonQuery();
            //Đóng kết nối
            ket_noi.Close();
            if (so_dong_anh_huong == -1)
            {
                return true;
            }
            return false;
        }      
        //restore
        public static bool Restore(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(KNoiRestore);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            int so_dong_anh_huong = lenh.ExecuteNonQuery();
            //Đóng kết nối
            ket_noi.Close();
            if (so_dong_anh_huong == -1)
            {
                return true;
            }
            return false;
        }
        //
        public static int ThucThi(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            int so_dong_anh_huong = lenh.ExecuteNonQuery();
            //Đóng kết nối
            ket_noi.Close();
            return so_dong_anh_huong;
        }
        //lay du lieu don : input la cau truy van... out : 1 gia tri don kieu int
        public static int ScalarKieuInt(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            int dulieu = 0;
            object kq = lenh.ExecuteScalar();
            if (kq != null) dulieu = (int)kq;
            //Đóng kết nối
            ket_noi.Close();

            return dulieu;
        }
        //lay du lieu don : input la cau truy van... out : 1 gia tri don kieu string
        public static string ScalarKieuString(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            string dulieu = string.Empty;
            object kq = lenh.ExecuteScalar();
            if (kq != null) dulieu = kq.ToString();
            //Đóng kết nối
            ket_noi.Close();

            return dulieu;
        }
        // goi store

    }
}
