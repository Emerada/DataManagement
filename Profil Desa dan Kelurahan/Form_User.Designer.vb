<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_User
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_User))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtSumberData = New System.Windows.Forms.TextBox()
        Me.txtKataSandi = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtKelurahan = New System.Windows.Forms.TextBox()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.txtPekerjaan = New System.Windows.Forms.TextBox()
        Me.txtNamaPengisi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboTampil = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'txtSumberData
        '
        Me.txtSumberData.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtSumberData, "Data tidak boleh kosong")
        Me.txtSumberData.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtSumberData, 5)
        Me.txtSumberData.Location = New System.Drawing.Point(98, 120)
        Me.txtSumberData.Name = "txtSumberData"
        Me.txtSumberData.Size = New System.Drawing.Size(143, 20)
        Me.txtSumberData.TabIndex = 3
        '
        'txtKataSandi
        '
        Me.txtKataSandi.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtKataSandi, "Data tidak boleh kosong")
        Me.txtKataSandi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtKataSandi, 5)
        Me.txtKataSandi.Location = New System.Drawing.Point(98, 70)
        Me.txtKataSandi.Name = "txtKataSandi"
        Me.txtKataSandi.Size = New System.Drawing.Size(143, 20)
        Me.txtKataSandi.TabIndex = 2
        Me.txtKataSandi.UseSystemPasswordChar = True
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtKode, "Data tidak boleh kosong")
        Me.txtKode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtKode, 5)
        Me.txtKode.Location = New System.Drawing.Point(98, 44)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(143, 20)
        Me.txtKode.TabIndex = 1
        '
        'txtKelurahan
        '
        Me.txtKelurahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtKelurahan, "Data tidak boleh kosong")
        Me.txtKelurahan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtKelurahan, 5)
        Me.txtKelurahan.Location = New System.Drawing.Point(98, 18)
        Me.txtKelurahan.Name = "txtKelurahan"
        Me.txtKelurahan.Size = New System.Drawing.Size(143, 20)
        Me.txtKelurahan.TabIndex = 0
        '
        'txtJabatan
        '
        Me.txtJabatan.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtJabatan, "Data tidak boleh kosong")
        Me.txtJabatan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtJabatan, 5)
        Me.txtJabatan.Location = New System.Drawing.Point(98, 70)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(143, 20)
        Me.txtJabatan.TabIndex = 6
        '
        'txtPekerjaan
        '
        Me.txtPekerjaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtPekerjaan, "Data tidak boleh kosong")
        Me.txtPekerjaan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtPekerjaan, 5)
        Me.txtPekerjaan.Location = New System.Drawing.Point(98, 44)
        Me.txtPekerjaan.Name = "txtPekerjaan"
        Me.txtPekerjaan.Size = New System.Drawing.Size(143, 20)
        Me.txtPekerjaan.TabIndex = 5
        '
        'txtNamaPengisi
        '
        Me.txtNamaPengisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ErrorProvider1.SetError(Me.txtNamaPengisi, "Data tidak boleh kosong")
        Me.txtNamaPengisi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconPadding(Me.txtNamaPengisi, 5)
        Me.txtNamaPengisi.Location = New System.Drawing.Point(98, 18)
        Me.txtNamaPengisi.Name = "txtNamaPengisi"
        Me.txtNamaPengisi.Size = New System.Drawing.Size(143, 20)
        Me.txtNamaPengisi.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(12, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 53)
        Me.Panel1.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(166, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(28, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Data Kelurahan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cboTampil)
        Me.Panel2.Controls.Add(Me.txtSumberData)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtKataSandi)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtKode)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtKelurahan)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 157)
        Me.Panel2.TabIndex = 4
        '
        'cboTampil
        '
        Me.cboTampil.AutoSize = True
        Me.cboTampil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTampil.Location = New System.Drawing.Point(98, 96)
        Me.cboTampil.Name = "cboTampil"
        Me.cboTampil.Size = New System.Drawing.Size(127, 18)
        Me.cboTampil.TabIndex = 14
        Me.cboTampil.Text = "Tampilkan Kata Sandi"
        Me.cboTampil.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 14)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Sumber Data"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 14)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Kata Sandi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 14)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Kode Regis."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 14)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Kelurahan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Data Pengisi"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtJabatan)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtPekerjaan)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtNamaPengisi)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Location = New System.Drawing.Point(12, 199)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 112)
        Me.Panel3.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 14)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Jabatan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 14)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Pekerjaan"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 14)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Nama Pengisi"
        '
        'Form_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 380)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting | User"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPengisi As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSumberData As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKataSandi As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKelurahan As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboTampil As System.Windows.Forms.CheckBox
End Class
