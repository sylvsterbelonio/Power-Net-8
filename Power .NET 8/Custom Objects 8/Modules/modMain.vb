Module modMain



    Sub main()
        AddHandler Application.ThreadException, AddressOf myExceptionHandler.OnThreadException

        Try
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
        Catch ex As Exception

        End Try


        'Dim frm As New Form1
        'frm.ShowDialog()

    End Sub


End Module
