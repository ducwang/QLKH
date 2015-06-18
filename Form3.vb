Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Form3
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=ducvgps02588.mssql.somee.com;packet size=4096;user id=ducwang_SQLLogin_1;pwd=37qdqryjok;data source=ducvgps02588.mssql.somee.com;persist security info=False;initial catalog=ducvgps02588"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvLoad.DataSource = database.DefaultView
    End Sub

    Private Sub dgvLoad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoad.CellContentClick
        Dim index As Integer = dgvLoad.CurrentCell.RowIndex
        o1.Text = dgvLoad.Item(0, index).Value
        o2.Text = dgvLoad.Item(1, index).Value
        o3.Text = dgvLoad.Item(2, index).Value
        o4.Text = dgvLoad.Item(3, index).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into khachhang values (@MaKH,@TenKH,@SDT,@DiaChi)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaKH", o1.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenKH", o2.Text)
            ExecuteQuery1.Parameters.AddWithValue("@SDT", o3.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DiaChi", o4.Text)


            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from khachhang", connect)
        database.Clear()

        Query3.Fill(database)
        dgvLoad.DataSource = database.DefaultView

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from KHACHHANG where MaKH=@MaKH"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaKH", o1.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvLoad.DataSource = database
        dgvLoad.DataSource = Nothing
        Loaddata()


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Ketnoi1 As New SqlConnection(chuoiconnect)
        Ketnoi1.Open()
        Dim Stradd1 As String = "Update KHACHHANG set TenKH=@TenKH,SDT=@SDT,DiaChi=@DiaChi where MaKH=@MaKH"
        Dim com As New SqlCommand(Stradd1, Ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaKH", o1.Text)
            com.Parameters.AddWithValue("@TenKH", o2.Text)
            com.Parameters.AddWithValue("@SoDT", o3.Text)
            com.Parameters.AddWithValue("@DiaChi", o4.Text)
            com.ExecuteNonQuery()
            Ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        database.Clear()
        dgvLoad.DataSource = database
        dgvLoad.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)

        connect.Open()
        Query1.Fill(database)
        dgvLoad.DataSource = database.DefaultView
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub


End Class

