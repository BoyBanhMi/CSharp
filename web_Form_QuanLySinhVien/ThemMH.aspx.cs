using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class ThemMH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gr_MonHoc.DataSource = MonHoc_XuLy.DS_MonHoc();
        gr_MonHoc.DataBind();
    }
    protected void btn_Them_Click(object sender, EventArgs e)
    {
        try
        {
            MonHoc_XuLy.Them(txt_MaMH.Text, txt_TenMH.Text, byte.Parse(txt_soDVHT.Text));
            gr_MonHoc.DataSource = MonHoc_XuLy.DS_MonHoc();
            gr_MonHoc.DataBind();
            lbl_thongbao.Text = "Thêm Thành Công";
        }
        catch
        {
            lbl_thongbao.Text = "Lỗi CSDL";
        }
    }
    protected void btn_sua_Click(object sender, EventArgs e)
    {
        try
        {
            MonHoc_XuLy.sua(txt_MaMH.Text, txt_TenMH.Text,byte.Parse(txt_soDVHT.Text));
            gr_MonHoc.DataSource = MonHoc_XuLy.DS_MonHoc();
            gr_MonHoc.DataBind();
            lbl_thongbao.Text = "Sửa Thành Công";
        }
        catch
        {
            lbl_thongbao.Text = "Lỗi CSDL";
        }
    }
    protected void btn_Xoa_Click(object sender, EventArgs e)
    {
        MonHoc_XuLy.xoa(txt_MaMH.Text);
        gr_MonHoc.DataSource = MonHoc_XuLy.DS_MonHoc();
        gr_MonHoc.DataBind();
        lbl_thongbao.Text = "Xóa Thành Công";
    }
    protected void btn_Huy_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}