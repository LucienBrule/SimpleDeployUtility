Imports System
Imports System.IO
Imports System.Diagnostics

Public Class simple_deploy_form
    Sub console_log(text As String)
        Console.WriteLine(text)
        console_output.AppendText(text & Environment.NewLine)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ensure depedancies are met
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = "where"
        ProcessProperties.UseShellExecute = False
        ProcessProperties.RedirectStandardOutput = True
        ProcessProperties.RedirectStandardError = True
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        ProcessProperties.CreateNoWindow = True

        Dim process As New Process

        Dim dependencies As New List(Of String) From {"which", "git", "make", "ssh"}
        For Each element As String In dependencies
            Try
                Console.WriteLine("trying" & element)
                ProcessProperties.Arguments = element
                process = Process.Start(ProcessProperties)

                ' Synchronously read the standard output of the spawned process. 
                Dim reader As StreamReader = process.StandardOutput
                Dim output As String = reader.ReadToEnd()
                Console.WriteLine(output)



                process.WaitForExit()
                process.Close()

            Catch ex As Exception
                console_log("warn> Missing dependancy: " & element.ToString)
                console_log(ex.ToString)
            End Try
        Next

        console_log("info> Application loaded")
    End Sub

    Private Sub Deploy_Code_Click(sender As Object, e As EventArgs)
        build_clean(sender, e)
        deploy_code(sender, e)
        kill_robot(sender, e)
    End Sub

    Private Sub additional_flags_tb_TextChanged(sender As Object, e As EventArgs) Handles additional_flags_tb.TextChanged
        'you can lint the flags here maybe
    End Sub

    Private Sub apply_flags_btn_handler(sender As Object, e As EventArgs) Handles apply_flags_btn.Click
        console_log("info> Flags have been changed:")
        console_log("----> " & additional_flags_tb.Text)
    End Sub
    Private Sub apply_makefilepath_btn_handler(sender As Object, e As EventArgs) Handles apply_makefilepath_btn.Click
        console_log("info> make file path has been changed:")
        console_log("----> " & makefile_path_tb.Text)
    End Sub


    Private Sub deploy_code(sender As Object, e As EventArgs) Handles deploy_code_simple_btn.Click
        console_log("info> Deploying code ...")
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.WorkingDirectory = Application.StartupPath() & "\RobotCode2017"
        ProcessProperties.FileName = "make"
        ProcessProperties.Arguments = "deploy"
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit()
        myProcess.Close()
        console_log("----> Code deployed")

    End Sub
    Private Sub build_clean(sender As Object, e As EventArgs) Handles build_code_clean_btn.Click
        'run make build
        console_log("info> Building clean ... ")
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.WorkingDirectory = Application.StartupPath() & "\RobotCode2017"
        ProcessProperties.FileName = "make"
        ProcessProperties.Arguments = "clean"
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit()
        myProcess.Close()
        console_log("----> build clean success")


    End Sub
    Private Sub build_dirty(sender As Object, e As EventArgs) Handles build_code_btn.Click
        'run make build
        console_log("info> Building Dirty ...")
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.WorkingDirectory = Application.StartupPath() & "\RobotCode2017"
        ProcessProperties.FileName = "make"
        ProcessProperties.Arguments = "all"
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit()
        myProcess.Close()
        console_log("----> build dirty success")

    End Sub

    Private Sub pull_code(sender As Object, e As EventArgs) Handles pull_code_btn.Click, deploy_code_btn.Click
        'run git pull repo
        console_log("info> Cloning repository ...")
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = "git"
        ProcessProperties.Arguments = "clone " & remote_url_tb.Text
        Dim myProcess As New Process

        Try
            myProcess = Process.Start(ProcessProperties)
            console_log("----> Cloned into " & Application.StartupPath())
        Catch ex As Exception
            console_log("----> Clone error, reason:")
            console_log(ex.ToString)
        End Try
        myProcess.WaitForExit()
        myProcess.Close()

        'TODO: detect if repo exists, change path to it and pull latest
    End Sub
    Private Sub kill_robot(sender As Object, e As EventArgs) Handles kill_robot_btn.Click
        'run make build
        console_log("info> Killing robot ...")
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.WorkingDirectory = Application.StartupPath() & "\RobotCode2017"
        ProcessProperties.FileName = "make"
        ProcessProperties.Arguments = "kill-robot"
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit()
        myProcess.Close()
        console_log("----> Robot killed (sad!)")
    End Sub
End Class