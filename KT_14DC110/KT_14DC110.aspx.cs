using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KT_14DC110 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddl_LoaiDT.DataSource = DienThoai.DS_LoaiDT();
            ddl_LoaiDT.DataTextField = "TenLDT";
            ddl_LoaiDT.DataValueField = "MaLDT";
            ddl_LoaiDT.DataBind();
        }
        gr_DSDT.DataSource = DienThoai.DS_DienThoai();
        gr_DSDT.DataBind();
        gr_DSDT.HeaderRow.Cells[0].Text = "STT";
        gr_DSDT.HeaderRow.Cells[1].Text = "Mã điện thoại";
        gr_DSDT.HeaderRow.Cells[2].Text = "Tên điện thoại";
        gr_DSDT.HeaderRow.Cells[3].Text = "Đơn giá";
        gr_DSDT.HeaderRow.Cells[4].Text = "Phụ kiện kèm theo";
        gr_DSDT.HeaderRow.Cells[5].Text = "Loại điện thoại";
    }
    protected void btn_Them_Click(object sender, EventArgs e)
    {
        try
        {
            if (int.Parse(txt_DonGia.Text) <= 0)
            {
                WebMsgBox.Show("Đơn giá phải lớn hơn 0 ");
            }
            else
            {
                DienThoai.Them(txt_MaDT.Text, txt_TenDT.Text, int.Parse(txt_DonGia.Text), txt_PhuKien.Text, ddl_LoaiDT.SelectedValue.ToString());
                gr_DSDT.DataSource = DienThoai.DS_DienThoai();
                gr_DSDT.DataBind();
                lbl_ThongBao.Text = "Nhập thông tin thành công !!!";
            }
        }
        catch
        {
            WebMsgBox.Show("Mã vừa nhập đã tồn tại, vui lòng kiểm tra lại");
        }
        
    }
    protected void btn_Sua_Click(object sender, EventArgs e)
    {
        try
        {
            if (int.Parse(txt_DonGia.Text) <= 0)
            {
                WebMsgBox.Show("Đơn giá phải lớn hơn 0 ");
            }
            else
            {
                DienThoai.Sua(txt_MaDT.Text, txt_TenDT.Text, int.Parse(txt_DonGia.Text), txt_PhuKien.Text, ddl_LoaiDT.SelectedValue.ToString());
                gr_DSDT.DataSource = DienThoai.DS_DienThoai();
                gr_DSDT.DataBind();
                lbl_ThongBao.Text = "Sửa thành công !!!";
            }
        }
        catch
        {
            WebMsgBox.Show("Thất bại, Lỗi CSDL !!!");
        }
    }
    protected void btn_Xoa_Click(object sender, EventArgs e)
    {
        try
        {
            DienThoai.Xoa(txt_MaDT.Text);
            gr_DSDT.DataSource = DienThoai.DS_DienThoai();
            gr_DSDT.DataBind();
            lbl_ThongBao.Text = "Xóa thành công !!!";
        }
        catch
        {
            WebMsgBox.Show("Thất bại, lỗi CSDL ");
        }
    }
}