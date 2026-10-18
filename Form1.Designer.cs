namespace Lab01_ThongTinCaNhan;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblNamSinh = new Label();
        txtNamSinh = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        grpGioiTinh = new GroupBox();
        radNam = new RadioButton();
        radNu = new RadioButton();
        lblKhoa = new Label();
        cboKhoa = new ComboBox();
        btnHienThi = new Button();
        btnXoa = new Button();
        btnThoat = new Button();
        lblKetQuaTieuDe = new Label();
        txtKetQua = new TextBox();
        grpGioiTinh.SuspendLayout();
        SuspendLayout();
        //
        // lblTitle
        //
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.DarkBlue;
        lblTitle.Location = new Point(12, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(460, 40);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "ỨNG DỤNG THÔNG TIN CÁ NHÂN";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblHoTen
        //
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(30, 72);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ tên:";
        //
        // txtHoTen
        //
        txtHoTen.Location = new Point(130, 69);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(320, 27);
        txtHoTen.TabIndex = 2;
        //
        // lblNamSinh
        //
        lblNamSinh.AutoSize = true;
        lblNamSinh.Location = new Point(30, 112);
        lblNamSinh.Name = "lblNamSinh";
        lblNamSinh.TabIndex = 3;
        lblNamSinh.Text = "Năm sinh:";
        //
        // txtNamSinh
        //
        txtNamSinh.Location = new Point(130, 109);
        txtNamSinh.MaxLength = 4;
        txtNamSinh.Name = "txtNamSinh";
        txtNamSinh.Size = new Size(120, 27);
        txtNamSinh.TabIndex = 4;
        //
        // lblEmail
        //
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(30, 152);
        lblEmail.Name = "lblEmail";
        lblEmail.TabIndex = 5;
        lblEmail.Text = "Email:";
        //
        // txtEmail
        //
        txtEmail.Location = new Point(130, 149);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(320, 27);
        txtEmail.TabIndex = 6;
        //
        // grpGioiTinh
        //
        grpGioiTinh.Controls.Add(radNam);
        grpGioiTinh.Controls.Add(radNu);
        grpGioiTinh.Location = new Point(30, 188);
        grpGioiTinh.Name = "grpGioiTinh";
        grpGioiTinh.Size = new Size(420, 60);
        grpGioiTinh.TabIndex = 7;
        grpGioiTinh.TabStop = false;
        grpGioiTinh.Text = "Giới tính";
        //
        // radNam
        //
        radNam.AutoSize = true;
        radNam.Location = new Point(100, 25);
        radNam.Name = "radNam";
        radNam.TabIndex = 0;
        radNam.Text = "Nam";
        radNam.UseVisualStyleBackColor = true;
        //
        // radNu
        //
        radNu.AutoSize = true;
        radNu.Location = new Point(250, 25);
        radNu.Name = "radNu";
        radNu.TabIndex = 1;
        radNu.Text = "Nữ";
        radNu.UseVisualStyleBackColor = true;
        //
        // lblKhoa
        //
        lblKhoa.AutoSize = true;
        lblKhoa.Location = new Point(30, 267);
        lblKhoa.Name = "lblKhoa";
        lblKhoa.TabIndex = 8;
        lblKhoa.Text = "Khoa/Lớp:";
        //
        // cboKhoa
        //
        cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKhoa.FormattingEnabled = true;
        cboKhoa.Location = new Point(130, 264);
        cboKhoa.Name = "cboKhoa";
        cboKhoa.Size = new Size(320, 28);
        cboKhoa.TabIndex = 9;
        //
        // btnHienThi
        //
        btnHienThi.Location = new Point(30, 312);
        btnHienThi.Name = "btnHienThi";
        btnHienThi.Size = new Size(130, 36);
        btnHienThi.TabIndex = 10;
        btnHienThi.Text = "Hiển thị";
        btnHienThi.UseVisualStyleBackColor = true;
        btnHienThi.Click += btnHienThi_Click;
        //
        // btnXoa
        //
        btnXoa.Location = new Point(180, 312);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(130, 36);
        btnXoa.TabIndex = 11;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        //
        // btnThoat
        //
        btnThoat.Location = new Point(320, 312);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(130, 36);
        btnThoat.TabIndex = 12;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += btnThoat_Click;
        //
        // lblKetQuaTieuDe
        //
        lblKetQuaTieuDe.AutoSize = true;
        lblKetQuaTieuDe.Location = new Point(30, 365);
        lblKetQuaTieuDe.Name = "lblKetQuaTieuDe";
        lblKetQuaTieuDe.TabIndex = 13;
        lblKetQuaTieuDe.Text = "Kết quả:";
        //
        // txtKetQua
        //
        txtKetQua.Location = new Point(30, 390);
        txtKetQua.Multiline = true;
        txtKetQua.Name = "txtKetQua";
        txtKetQua.ReadOnly = true;
        txtKetQua.Size = new Size(420, 130);
        txtKetQua.TabIndex = 14;
        txtKetQua.TabStop = false;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 541);
        Controls.Add(lblTitle);
        Controls.Add(lblHoTen);
        Controls.Add(txtHoTen);
        Controls.Add(lblNamSinh);
        Controls.Add(txtNamSinh);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(grpGioiTinh);
        Controls.Add(lblKhoa);
        Controls.Add(cboKhoa);
        Controls.Add(btnHienThi);
        Controls.Add(btnXoa);
        Controls.Add(btnThoat);
        Controls.Add(lblKetQuaTieuDe);
        Controls.Add(txtKetQua);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lab 01 - Thông tin cá nhân";
        Load += Form1_Load;
        grpGioiTinh.ResumeLayout(false);
        grpGioiTinh.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblNamSinh;
    private TextBox txtNamSinh;
    private Label lblEmail;
    private TextBox txtEmail;
    private GroupBox grpGioiTinh;
    private RadioButton radNam;
    private RadioButton radNu;
    private Label lblKhoa;
    private ComboBox cboKhoa;
    private Button btnHienThi;
    private Button btnXoa;
    private Button btnThoat;
    private Label lblKetQuaTieuDe;
    private TextBox txtKetQua;
}
