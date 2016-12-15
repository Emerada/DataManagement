Public Class Form_User

    Private Sub Form_User_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ErrorProvider1.Dispose()
        With My.Settings
            txtKelurahan.Text = .Kelurahan
            txtKode.Text = .Kode_Desa
            txtKataSandi.Text = .Password_Desa
            txtSumberData.Text = .Sumber_Data
            txtNamaPengisi.Text = .Nama_Pengisi
            txtPekerjaan.Text = .Pekerjaan
            txtJabatan.Text = .Jabatan
        End With
    End Sub

    Private Sub txtKelurahan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKelurahan.Validating
        If txtKelurahan.Text Is String.Empty Then
            ErrorProvider1.SetError(txtKelurahan, "Nama Kelurahan tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtKelurahan, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub txtKode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKode.Validating
        If txtKode.Text Is String.Empty Then
            ErrorProvider1.SetError(txtKode, "Kode Registrasi tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtKode, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub txtKataSandi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKataSandi.Validating
        If txtKataSandi.Text Is String.Empty Then
            ErrorProvider1.SetError(txtKataSandi, "Kata Sandi tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtKataSandi, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTampil.CheckedChanged
        If cboTampil.Checked Then
            txtKataSandi.UseSystemPasswordChar = False
        Else
            txtKataSandi.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtSumberData_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSumberData.Validating
        If txtSumberData.Text Is String.Empty Then
            ErrorProvider1.SetError(txtSumberData, "Sumber Data tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtSumberData, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub txtNamaPengisi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNamaPengisi.Validating
        If txtNamaPengisi.Text Is String.Empty Then
            ErrorProvider1.SetError(txtNamaPengisi, "Nama Pengisi tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtNamaPengisi, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub txtPekerjaan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPekerjaan.Validating
        If txtPekerjaan.Text Is String.Empty Then
            ErrorProvider1.SetError(txtPekerjaan, "Pekerjaan tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtPekerjaan, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub txtJabatan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtJabatan.Validating
        If txtJabatan.Text Is String.Empty Then
            ErrorProvider1.SetError(txtJabatan, "Jabatan tidak boleh kosong")
            ErrorProvider1.SetIconPadding(txtJabatan, 5)
        Else
            ErrorProvider1.Dispose()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKelurahan.Text Is String.Empty Or _
            txtKode.Text Is String.Empty Or _
            txtKataSandi.Text Is String.Empty Or _
            txtSumberData.Text Is String.Empty Or _
            txtNamaPengisi.Text Is String.Empty Or _
            txtPekerjaan.Text Is String.Empty Or _
            txtJabatan.Text Is String.Empty Then

            MsgBox("Harap isi data yang kosong !", vbExclamation)
        Else
            If MsgBox("Apakah Anda yakin ingin menyimpan data, dengan data sebagai berikut: " + vbCrLf + _
                      "Kelurahan " + vbTab + ": KELURAHAN " + txtKelurahan.Text.ToUpper + vbCrLf + _
                      "Kode Registrasi" + vbTab + ": " + txtKode.Text.ToUpper + vbCrLf + _
                      "Kata Sandi " + vbTab + ": " + txtKataSandi.Text.ToUpper + vbCrLf + _
                      "Sumber Data" + vbTab + ": " + txtSumberData.Text.ToUpper + vbCrLf + _
                      "Nama Pengisi" + vbTab + ": " + txtNamaPengisi.Text.ToUpper + vbCrLf + _
                      "Pekerjaan  " + vbTab + ": " + txtPekerjaan.Text.ToUpper + vbCrLf + _
                      "Jabatan" + vbTab + vbTab + ": " + txtJabatan.Text.ToUpper + vbCrLf, vbYesNo) = vbYes Then
                With My.Settings
                    .Kelurahan = txtKelurahan.Text.ToUpper
                    .Kode_Desa = txtKode.Text.ToUpper
                    .Password_Desa = txtKataSandi.Text.ToUpper
                    .Sumber_Data = txtSumberData.Text.ToUpper
                    .Nama_Pengisi = txtNamaPengisi.Text.ToUpper
                    .Pekerjaan = txtPekerjaan.Text.ToUpper
                    .Jabatan = txtJabatan.Text.ToUpper

                    .Save()

                    Me.Close()
                End With
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtKelurahan.Clear()
        txtKode.Clear()
        txtKataSandi.Clear()
        txtSumberData.Clear()
        txtNamaPengisi.Clear()
        txtPekerjaan.Clear()
        txtJabatan.Clear()
    End Sub
End Class