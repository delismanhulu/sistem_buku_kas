Imports System.Data.Odbc
Module Module1
    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public DataReaderCek As OdbcDataReader
    Public Lokasi As String

    Sub KONEKSIDB()
        Lokasi = System.Environment.CurrentDirectory
        Try
            konek = New OdbcConnection("DSN=DB_BUKU_KAS;MultipleActiveResultSets=True")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function CekRecord(ByVal qry As String) As Boolean
        CMD = New OdbcCommand(qry, konek)
        DataReaderCek = CMD.ExecuteReader
        If DataReaderCek.HasRows Then
            CekRecord = True
        Else
            CekRecord = False
        End If
        CMD.Dispose()
        DataReaderCek.Close()
    End Function
    Public Function MD5(ByVal strToHash As String) As String
        Dim md5login As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5login.ComputeHash(bytesToHash)
        Dim hasil As String = ""
        Dim usermd5 As Byte
        For Each usermd5 In bytesToHash
            hasil += usermd5.ToString("x2")
        Next
        Return hasil
    End Function

End Module
