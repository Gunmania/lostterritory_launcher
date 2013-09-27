Option Strict Off
Option Explicit On
Friend Class main
    Inherits System.Windows.Forms.Form

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Private Const SW_SHOWNORMAL As Short = 1

    Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" (ByVal pCaller As Integer, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Integer) As Integer

    Public Function DownloadFile(ByVal URL As String, ByVal LocalFilename As String) As Boolean
        Dim lngRetVal As Integer
        On Error Resume Next
        lngRetVal = URLDownloadToFile(0, URL, LocalFilename, 0, 0)
        If lngRetVal = 0 Then
            DownloadFile = True
        Else
            DownloadFile = False
        End If
    End Function

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim FileNo As Integer
        Dim UrlFile As Integer
        Dim CheckFileUrl As String
        Dim NewestVer As String
        CheckFileUrl = ""

        UrlFile = FreeFile()
        FileOpen(UrlFile, "server.txt", OpenMode.Input)
        While Not EOF(UrlFile)
            CheckFileUrl = LineInput(UrlFile)
        End While
        FileClose(UrlFile)

        Dim Ver As String
        Ver = "20130927"
        On Error Resume Next
        FileNo = FreeFile()

        Dim exists As Boolean
        exists = System.IO.Directory.Exists("C:\Users\Public")

        If System.IO.Directory.Exists("C:\Users\Public") <> True Then
            System.IO.Directory.CreateDirectory("C:\Users\Public")
        End If

        If DownloadFile(CheckFileUrl, "c:\users\public\temp.txt") Then
            NewestVer = ""
            FileOpen(FileNo, "c:\users\public\temp.txt", OpenMode.Input)
            While Not EOF(FileNo)
                NewestVer = LineInput(FileNo)
            End While
            FileClose(FileNo)
            If NewestVer <> Ver Then
                MsgBox("새 버전이 나왔습니다. 공식 사이트(http://witteam.gunmania.kr)에서 새 버전을 다운받으시기 바랍니다", MsgBoxStyle.Critical, "업데이트 체크")
                End
            End If
        Else
            MsgBox("서버에서 업데이트 정보를 받아오는데 실패하였습니다.", MsgBoxStyle.Critical, "Error")
            End
        End If
        Kill("c:\temp.txt")

    End Sub

    Private Sub Image2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MapImage1.Click
        ShellExecute(Me.Handle.ToInt32, "open", "town.exe", vbNullString, "town", SW_SHOWNORMAL)
    End Sub

    Private Sub Label3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label3.Click
        ShellExecute(Me.Handle.ToInt32, "open", "town.exe", vbNullString, "town", SW_SHOWNORMAL)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Frame1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame1.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        ShellExecute(Me.Handle.ToInt32, "open", "bunker.exe", vbNullString, "bunker", SW_SHOWNORMAL)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapImage2.Click
        ShellExecute(Me.Handle.ToInt32, "open", "bunker.exe", vbNullString, "bunker", SW_SHOWNORMAL)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("준비중입니다", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://witteam.gunmania.kr")
    End Sub
End Class