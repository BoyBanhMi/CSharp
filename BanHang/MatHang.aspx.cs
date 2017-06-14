using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MatHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            DDL_LMH.DataSource = MatHang_XuLy.DS_LoaiMH();
            DDL_LMH.DataTextField = "TenLMH";
            DDL_LMH.DataValueField = "MaLMH";
            DDL_LMH.DataBind();
        }
        gv_DSMH.DataSource = MatHang_XuLy.DS_MatHang();
        gv_DSMH.DataBind();
         
    }
    protected void btn_them_Click(object sender, EventArgs e)
    {
        try
        {
            MatHang_XuLy.Them(txt_MaMH.Text, txt_TenMH.Text, int.Parse(txt_DonGia.Text), DDL_LMH.SelectedValue.ToString());
            gv_DSMH.DataSource = MatHang_XuLy.DS_MatHang();
            gv_DSMH.DataBind();
            lbl_TB.Text = "Thêm thành Công";
        }
        catch
        {
            lbl_TB.Text = "Lỗi CSDL, Không thêm được";
        }
    }
    protected void btn_Xoa_Click(object sender, EventArgs e)
    {
        try
        {
            MatHang_XuLy.Xoa(txt_MaMH.Text);
            gv_DSMH.DataSource = MatHang_XuLy.DS_MatHang();
            gv_DSMH.DataBind();
            lbl_TB.Text = "Xóa Thành Công";
        }
        catch
        {
            lbl_TB.Text = "Lỗi CSDL, Không Xóa Được";
        }
    }

    protected void btn_sua_Click(object sender, EventArgs e)
    {
        try
        {
            MatHang_XuLy.Sua(txt_MaMH.Text, txt_TenMH.Text, int.Parse(txt_DonGia.Text), DDL_LMH.SelectedValue.ToString());
            gv_DSMH.DataSource = MatHang_XuLy.DS_MatHang();
            gv_DSMH.DataBind();
            lbl_TB.Text = "Sửa Thành Công";
        }
        catch
        {
            lbl_TB.Text = "Lõi CSDl,không sửa được";
        }
    }
}