<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.o4 = New System.Windows.Forms.TextBox()
        Me.o3 = New System.Windows.Forms.TextBox()
        Me.o2 = New System.Windows.Forms.TextBox()
        Me.o1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvLoad = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(144, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(429, 31)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Quản Lý Thông Tin Khách Hàng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "SĐT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tên KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mã KH"
        '
        'o4
        '
        Me.o4.Location = New System.Drawing.Point(169, 193)
        Me.o4.Name = "o4"
        Me.o4.Size = New System.Drawing.Size(100, 20)
        Me.o4.TabIndex = 24
        '
        'o3
        '
        Me.o3.Location = New System.Drawing.Point(169, 169)
        Me.o3.Name = "o3"
        Me.o3.Size = New System.Drawing.Size(100, 20)
        Me.o3.TabIndex = 23
        '
        'o2
        '
        Me.o2.Location = New System.Drawing.Point(169, 143)
        Me.o2.Name = "o2"
        Me.o2.Size = New System.Drawing.Size(100, 20)
        Me.o2.TabIndex = 22
        '
        'o1
        '
        Me.o1.Location = New System.Drawing.Point(71, 143)
        Me.o1.Name = "o1"
        Me.o1.Size = New System.Drawing.Size(42, 20)
        Me.o1.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(192, 313)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 42)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Thoát"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(102, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 42)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Sửa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 42)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Xóa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvLoad
        '
        Me.dgvLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoad.Location = New System.Drawing.Point(287, 143)
        Me.dgvLoad.Name = "dgvLoad"
        Me.dgvLoad.Size = New System.Drawing.Size(380, 212)
        Me.dgvLoad.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "______ducvgps02588"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 382)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.o4)
        Me.Controls.Add(Me.o3)
        Me.Controls.Add(Me.o2)
        Me.Controls.Add(Me.o1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvLoad)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form3"
        Me.Text = "Chỉnh Sửa Thông Tin Khách Hàng"
        CType(Me.dgvLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents o4 As System.Windows.Forms.TextBox
    Friend WithEvents o3 As System.Windows.Forms.TextBox
    Friend WithEvents o2 As System.Windows.Forms.TextBox
    Friend WithEvents o1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvLoad As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
