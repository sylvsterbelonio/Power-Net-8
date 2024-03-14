Public Class frmSample
    Private timer As New Timer



    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        PowerNET8.myFunctions.Share.Themes.GetThemes(Me, timer, "sylvster")
    End Sub

    Private Sub My8Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'ComboBox1.SelectedIndex = 100
        Catch ex As Exception
            PowerNET8.myExceptionHandler.OnThreadException(ex)
        End Try


    End Sub

    Private Sub My8Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button1.Click
        If start_button.Enabled Then
            RichTextBox1.ReadOnly = False
            TextBox1.ReadOnly = False
            start_button.Enabled = False
            DomainUpDown1.Enabled = True
            ComboBox2.Enabled = True
            MaskedTextBox1.ReadOnly = False
            ComboBox1.Enabled = True
            CheckedListBox1.Enabled = True
            ListBox1.Enabled = True
        Else
            RichTextBox1.ReadOnly = True
            ListBox1.Enabled = False
            CheckedListBox1.Enabled = False

            ComboBox2.Enabled = False
            ComboBox1.Enabled = False
            TextBox1.ReadOnly = True
            start_button.Enabled = True
            MaskedTextBox1.ReadOnly = True
            DomainUpDown1.Enabled = False
        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub


    Private Sub frmSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        my_BGWorker.RunWorkerAsync()
    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles my_BGWorker.DoWork

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles my_BGWorker.ProgressChanged
        MsgBox("ad")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles my_BGWorker.RunWorkerCompleted

    End Sub


    Private Sub start_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start_button.Click
        PowerNET8.myVisualEffects.ColorFadeEffects.AddEffects(FlowLayoutPanel1, "backcolor", Color.White, Color.Beige, 25, Color.White, 25, 20)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint

    End Sub

  
    Private Sub DataGridView1_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button2.Click
        Dim color As Color = color.Red
        TextBox1.BackColor = Drawing.Color.Red
        'Dim adkColor As Color = color.FromArgb(color.A, Val(color.R * TextBox2.Text), Val(color.G * TextBox2.Text), Val(color.B * TextBox2.Text))
        FlowLayoutPanel1.BackColor = ControlPaint.Light(b, txtAlternate.Text)

        DataGridView1.BackgroundColor = ControlPaint.Light(b, txtBackColor.Text)

        DataGridView1.DefaultCellStyle.BackColor = ControlPaint.Light(b, txtDefault.Text)
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ControlPaint.Light(b, txtAlternate.Text)

        'DataGridView1.GridColor = ControlPaint.Light(b, txtAlternate.Text)
        DataGridView1.DefaultCellStyle.SelectionBackColor = ControlPaint.Light(b, txtHighlight.Text)
        DataGridView1.DefaultCellStyle.SelectionForeColor = Drawing.Color.White

        DataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = ControlPaint.Light(b, txtHighlight.Text)
        DataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Drawing.Color.White

        DataGridView1.Columns(2).DefaultCellStyle.BackColor = ControlPaint.Light(b, txtReadOnly.Text)
        'DataGridView1.Columns(2).DefaultCellStyle.SelectionBackColor = ControlPaint.Light(b, txtHighlight.Text)
        txtReadFore.BackColor = ControlPaint.Light(b, txtAlternate.Text)
        My8Button2.BackColor = b
    End Sub

    Dim c As Color
    Dim b As Color
    Private Sub pick(ByVal color As Color) Handles AccentColor1.ColorPicked
        c = color
    End Sub

    Private Sub pick2(ByVal color As Color) Handles BackgroundColor1.ColorPicked
        b = color
    End Sub

    Private Sub AccentColor1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccentColor1.Load

    End Sub

    Private Sub My8Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class