Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Private Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Private Const SW_SHOWNORMAL As Short = 1
	
	Private Declare Function URLDownloadToFile Lib "urlmon"  Alias "URLDownloadToFileA"(ByVal pCaller As Integer, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Integer) As Integer
	
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
		Dim NewestVer As String
		Dim Ver As String
		Ver = "20100117"
		On Error Resume Next
		FileNo = FreeFile
		
		If DownloadFile("http://lostterritory.gunmania.co.cc/ver.txt", "c:\temp.txt") Then
			NewestVer = ""
			FileOpen(FileNo, "c:\temp.txt", OpenMode.Input)
			While Not EOF(FileNo)
                NewestVer = LineInput(FileNo)
			End While
			FileClose(FileNo)
            If NewestVer <> Ver Then
                MsgBox("최신버전이 나왔습니다. 공식사이트(http://lostterritory.gunmania.co.cc)에서 새 버전을 다운받으시기 바랍니다", MsgBoxStyle.Critical, "업데이트 체크")
                End
            End If
		Else
			MsgBox("서버에서 최신버전을 확인할수 없습니다.", MsgBoxStyle.Critical, "Error")
			End
		End If
        Kill("c:\temp.txt")

	End Sub
	
	Private Sub Image2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image2.Click
		ShellExecute(Me.Handle.ToInt32, "open", "town_alpha3.exe", vbNullString, "C:\Program Files\W.I.T Team\Lost Territory\Map_1", SW_SHOWNORMAL)
	End Sub
	
	Private Sub Label3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label3.Click
		ShellExecute(Me.Handle.ToInt32, "open", "town_alpha3.exe", vbNullString, "C:\Program Files\W.I.T Team\Lost Territory\Map_1", SW_SHOWNORMAL)
    End Sub

End Class