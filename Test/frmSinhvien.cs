using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Test.Model;
using static Test.QuanlySVDataSet;

namespace Test
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
            LoadSinhVienList();
            LoadLopHocList();
        }

        private void LoadSinhVienList()
        {
            // Tạo danh sách sinh viên mẫu
            var sinhVienList = new List<SinhVienlistview>
    {
        new SinhVienlistview { MaSV = "SV0001", hovaten = "Trần Văn Nam", ngaysinh = "20/08/1985", lopp = "Công nghệ thông tin"   },
        new SinhVienlistview { MaSV = "SV0002", hovaten = "Nguyễn Thị Tuyết", ngaysinh = "25/08/1986", lopp = "kế toán khóa 1" },
        new SinhVienlistview { MaSV = "SV0003", hovaten = "Nguyễn Kim Tuyến", ngaysinh = "21/03/1984", lopp = "kế toán khóa 1"}

    };

            lvSinhvien.Items.Clear();

            foreach (var sv in sinhVienList)
            {
                var item = new ListViewItem(sv.MaSV.ToString());
                item.SubItems.Add(sv.hovaten);
                item.SubItems.Add(sv.ngaysinh.ToString());
                item.SubItems.Add(sv.lopp.ToString());

                lvSinhvien.Items.Add(item);
            }
        }

        private void LoadLopHocList()
        {
            // Tạo danh sách lớp học mẫu
            var lopHocList = new List<LopListview>
        {
            new LopListview { MaLop = 1, TenLop = "Công nghệ thông tin" },
            new LopListview { MaLop = 2, TenLop = "Kế toán khóa 1" },
        };

            // Gán danh sách lớp học vào ComboBox
            cboLop.DataSource = lopHocList;
            cboLop.DisplayMember = "Tên lớp";
            

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {

        }

        private void lvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSinhvien_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHotenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void btKhong_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tắt?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lvSinhvien_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
