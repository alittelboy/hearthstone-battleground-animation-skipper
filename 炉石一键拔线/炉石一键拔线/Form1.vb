Imports System.IO

Public Class Form1
    Dim rootdir As String = ""
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim LSdir As String

        Dim blocktxt As String =
            "%1 mshta vbscript:CreateObject(""Shell.Application"").ShellExecute(""cmd.exe"",""/c %~s0 ::"","""",""runas"",0)(window.close)&&exit" & vbNewLine &
            "C:\Windows\System32\netsh advfirewall firewall set rule name=""lushi"" new enable=yes"
        Dim connecttxt As String =
            "%1 mshta vbscript:CreateObject(""Shell.Application"").ShellExecute(""cmd.exe"",""/c %~s0 ::"","""",""runas"",0)(window.close)&&exit" & vbNewLine &
            "C:\Windows\System32\netsh advfirewall firewall set rule name=""lushi"" new enable=no"
        Dim Swriter1 As New StreamWriter(rootdir & "block.bat", False) '覆盖或新建
        Swriter1.WriteLine(blocktxt)
        Swriter1.Close()
        Dim Swriter2 As New StreamWriter(rootdir & "connect.bat", False) '覆盖或新建
        Swriter2.WriteLine(connecttxt)
        Swriter2.Close()


        LSdir = TextBox1.Text.Trim()
        Dim setuptxt As String =
            "%1 mshta vbscript:CreateObject(""Shell.Application"").ShellExecute(""cmd.exe"",""/c %~s0 ::"","""",""runas"",1)(window.close)&&exit" & vbNewLine &
            "C:\Windows\System32\netsh advfirewall firewall delete rule name=""lushi"" " & vbNewLine &
            "C:\Windows\System32\netsh advfirewall firewall add rule name=""lushi"" dir=out action=block program=""" & LSdir & """ enable=no"
        Dim Swriter As New StreamWriter(rootdir & "setup.bat", False) '覆盖或新建
        Swriter.WriteLine(setuptxt)
        Swriter.Close()
        Shell(rootdir & "setup.bat", vbHidden)
        MsgBox("初始化完成！")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell(rootdir & "connect.bat")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim oShell
            oShell = CreateObject("WScript.Shell")
            rootdir = oShell.ExpandEnvironmentStrings("%APPDATA%")
            'MsgBox(rootdir)
            If Not Directory.Exists(rootdir & "\HSunplugging") Then
                Directory.CreateDirectory(rootdir & "\HSunplugging")
            End If
            rootdir = rootdir & "\HSunplugging\"
            'MsgBox(rootdir)
        Catch ex As Exception
            rootdir = ""
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell(rootdir & "block.bat", vbHidden)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell(rootdir & "block.bat", vbHidden)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Shell(rootdir & "connect.bat", vbHidden)
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Function GetKey() As String
        Dim KeyResultQ, KeyResultW, KeyResultE, KeyResultR As Integer
        KeyResultQ = GetAsyncKeyState(Asc("Q"))
        KeyResultW = GetAsyncKeyState(Asc("W"))
        KeyResultE = GetAsyncKeyState(Asc("E"))
        KeyResultR = GetAsyncKeyState(Asc("R"))
        '-32768（即道16进制数&H8000） --- 键当前处于按下状态，但在此之前（自上次调用GetAsyncKeyState后）键未被按过
        '但是int里是32769
        'And KeyResultW = 32769 And KeyResultE = 32769 And KeyResultR = 32769 
        If KeyResultQ <> 0 And KeyResultW <> 0 And KeyResultE <> 0 And KeyResultR <> 0 Then
            Return 1
        End If
        Return 0
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim test = GetKey()

        If test = 1 Then
            Timer2.Enabled = False
            Shell(rootdir & "block.bat", vbHidden)
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        rootdir = ""
    End Sub
End Class
