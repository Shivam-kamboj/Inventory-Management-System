Imports System.IO
Public Class StoreDetailsForm
    Private storefilepath As String = "StoreDetails.txt"
    'Loading store details when forms load
    Private Sub StoreDetailsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(storefilepath) Then
            Dim Details() As String = File.ReadAllLines(storefilepath) 'information is tranferred to array from File
            If Details.Length >= 4 Then
                Txtbox_Storename.Text = Details(0)
                Txtbox_Adress.Text = Details(1)
                Txtbox_Contact.Text = Details(2)
                MailTextBox.Text = Details(3)
            End If
        End If
        Dim addProduct As New AddProduct()
        addProduct.MakeButtonRounded(btn_Storeinfo)
    End Sub

    Private Sub btn_Storeinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Storeinfo.Click


        Dim storeName As String = Txtbox_Storename.Text.Trim()
        Dim storeAddress As String = Txtbox_Adress.Text.Trim()
        Dim storeContact As String = Txtbox_Contact.Text.Trim()
        Dim storeMail As String = MailTextBox.Text.Trim()

        ' Validation
        If storeName = "" And storeAddress = "" And storeContact = "" And Len(MailTextBox.Text) = 0 Then
            MessageBox.Show("Please enter all store details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Save to file
        File.WriteAllLines(storefilepath, {storeName, storeAddress, storeContact, storeMail})

        MessageBox.Show("Store details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
       
    End Sub


    Private Sub Txtbox_Contact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtbox_Contact.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub

End Class