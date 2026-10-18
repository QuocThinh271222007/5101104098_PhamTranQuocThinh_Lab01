namespace Lab01_ThongTinCaNhan;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Khi mở chương trình: nạp danh sách khoa/lớp cho ComboBox.
    /// </summary>
    private void Form1_Load(object? sender, EventArgs e)
    {
        cboKhoa.Items.AddRange(new object[]
        {
            "Công nghệ thông tin",
            "Kinh tế",
            "Ngoại ngữ",
            "Quản trị kinh doanh",
            "Kỹ thuật điện - điện tử"
        });
        cboKhoa.SelectedIndex = -1; // chưa chọn, bắt buộc người dùng chọn
    }

    /// <summary>
    /// Nút Hiển thị: kiểm tra dữ liệu rồi hiển thị thông tin sinh viên.
    /// </summary>
    private void btnHienThi_Click(object? sender, EventArgs e)
    {
        // Lấy dữ liệu, cắt khoảng trắng thừa hai đầu
        string hoTen = txtHoTen.Text.Trim();
        string namSinhText = txtNamSinh.Text.Trim();
        string email = txtEmail.Text.Trim();

        // 1. Họ tên không được rỗng
        if (hoTen == "")
        {
            BaoLoi("Vui lòng nhập họ tên.", txtHoTen);
            return;
        }

        // 2. Năm sinh không rỗng và phải là số nguyên
        if (namSinhText == "")
        {
            BaoLoi("Vui lòng nhập năm sinh.", txtNamSinh);
            return;
        }
        if (!int.TryParse(namSinhText, out int namSinh))
        {
            BaoLoi("Năm sinh phải là số nguyên.", txtNamSinh);
            return;
        }

        // 3. Năm sinh trong khoảng 1900 .. năm hiện tại
        int namHienTai = DateTime.Now.Year;
        if (namSinh < 1900 || namSinh > namHienTai)
        {
            BaoLoi($"Năm sinh phải nằm trong khoảng từ 1900 đến {namHienTai}.", txtNamSinh);
            return;
        }

        // 4. Email không được rỗng
        if (email == "")
        {
            BaoLoi("Vui lòng nhập email.", txtEmail);
            return;
        }

        // 5. Phải chọn giới tính
        if (!radNam.Checked && !radNu.Checked)
        {
            BaoLoi("Vui lòng chọn giới tính.", radNam);
            return;
        }

        // 6. Phải chọn khoa/lớp
        if (cboKhoa.SelectedIndex < 0)
        {
            BaoLoi("Vui lòng chọn khoa/lớp.", cboKhoa);
            return;
        }

        // Dữ liệu hợp lệ: tính tuổi và tạo chuỗi kết quả
        int tuoi = namHienTai - namSinh;
        string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
        string khoa = cboKhoa.SelectedItem!.ToString()!;

        string ketQua =
            "THÔNG TIN SINH VIÊN" + Environment.NewLine +
            "Họ tên: " + hoTen + Environment.NewLine +
            "Tuổi: " + tuoi + Environment.NewLine +
            "Email: " + email + Environment.NewLine +
            "Giới tính: " + gioiTinh + Environment.NewLine +
            "Khoa/Lớp: " + khoa;

        // Hiển thị trên Form và bằng MessageBox
        txtKetQua.Text = ketQua;
        MessageBox.Show(ketQua, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Nút Xóa: đưa toàn bộ dữ liệu nhập về trạng thái ban đầu.
    /// </summary>
    private void btnXoa_Click(object? sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtNamSinh.Clear();
        txtEmail.Clear();
        radNam.Checked = false;
        radNu.Checked = false;
        cboKhoa.SelectedIndex = -1;
        txtKetQua.Clear();
        txtHoTen.Focus();
    }

    /// <summary>
    /// Nút Thoát: hỏi xác nhận trước khi đóng chương trình.
    /// </summary>
    private void btnThoat_Click(object? sender, EventArgs e)
    {
        DialogResult kq = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát chương trình?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (kq == DialogResult.Yes)
        {
            Close();
        }
    }

    /// <summary>
    /// Hiện thông báo lỗi và đưa con trỏ về control bị lỗi.
    /// </summary>
    private void BaoLoi(string thongBao, Control control)
    {
        MessageBox.Show(thongBao, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        control.Focus();
    }
}
