<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class simple_deploy_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(simple_deploy_form))
        Me.deploy_code_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.kill_robot_btn = New System.Windows.Forms.Button()
        Me.deploy_code_simple_btn = New System.Windows.Forms.Button()
        Me.build_code_clean_btn = New System.Windows.Forms.Button()
        Me.build_code_btn = New System.Windows.Forms.Button()
        Me.pull_code_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.remote_url_tb = New System.Windows.Forms.TextBox()
        Me.apply_makefilepath_btn = New System.Windows.Forms.Button()
        Me.makefile_path_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.apply_flags_btn = New System.Windows.Forms.Button()
        Me.additional_flags_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.console_output = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'deploy_code_btn
        '
        Me.deploy_code_btn.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.deploy_code_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deploy_code_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deploy_code_btn.ForeColor = System.Drawing.Color.Chartreuse
        Me.deploy_code_btn.Location = New System.Drawing.Point(23, 77)
        Me.deploy_code_btn.Name = "deploy_code_btn"
        Me.deploy_code_btn.Size = New System.Drawing.Size(411, 158)
        Me.deploy_code_btn.TabIndex = 1
        Me.deploy_code_btn.Text = "DEPLOY CODE"
        Me.deploy_code_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-5, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 329)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage1.Controls.Add(Me.kill_robot_btn)
        Me.TabPage1.Controls.Add(Me.deploy_code_simple_btn)
        Me.TabPage1.Controls.Add(Me.build_code_clean_btn)
        Me.TabPage1.Controls.Add(Me.build_code_btn)
        Me.TabPage1.Controls.Add(Me.pull_code_btn)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.deploy_code_btn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(456, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deploy"
        '
        'kill_robot_btn
        '
        Me.kill_robot_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.kill_robot_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kill_robot_btn.ForeColor = System.Drawing.Color.Crimson
        Me.kill_robot_btn.Location = New System.Drawing.Point(307, 247)
        Me.kill_robot_btn.Name = "kill_robot_btn"
        Me.kill_robot_btn.Size = New System.Drawing.Size(127, 45)
        Me.kill_robot_btn.TabIndex = 7
        Me.kill_robot_btn.Text = "KILL ROBOT"
        Me.kill_robot_btn.UseVisualStyleBackColor = False
        '
        'deploy_code_simple_btn
        '
        Me.deploy_code_simple_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.deploy_code_simple_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deploy_code_simple_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.deploy_code_simple_btn.Location = New System.Drawing.Point(236, 247)
        Me.deploy_code_simple_btn.Name = "deploy_code_simple_btn"
        Me.deploy_code_simple_btn.Size = New System.Drawing.Size(65, 45)
        Me.deploy_code_simple_btn.TabIndex = 6
        Me.deploy_code_simple_btn.Text = "DEPLOY CODE"
        Me.deploy_code_simple_btn.UseVisualStyleBackColor = False
        '
        'build_code_clean_btn
        '
        Me.build_code_clean_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.build_code_clean_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.build_code_clean_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.build_code_clean_btn.Location = New System.Drawing.Point(165, 247)
        Me.build_code_clean_btn.Name = "build_code_clean_btn"
        Me.build_code_clean_btn.Size = New System.Drawing.Size(65, 45)
        Me.build_code_clean_btn.TabIndex = 5
        Me.build_code_clean_btn.Text = "BUILD CLEAN"
        Me.build_code_clean_btn.UseVisualStyleBackColor = False
        '
        'build_code_btn
        '
        Me.build_code_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.build_code_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.build_code_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.build_code_btn.Location = New System.Drawing.Point(94, 247)
        Me.build_code_btn.Name = "build_code_btn"
        Me.build_code_btn.Size = New System.Drawing.Size(65, 45)
        Me.build_code_btn.TabIndex = 4
        Me.build_code_btn.Text = "BUILD CODE"
        Me.build_code_btn.UseVisualStyleBackColor = False
        '
        'pull_code_btn
        '
        Me.pull_code_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pull_code_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pull_code_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.pull_code_btn.Location = New System.Drawing.Point(23, 247)
        Me.pull_code_btn.Name = "pull_code_btn"
        Me.pull_code_btn.Size = New System.Drawing.Size(65, 45)
        Me.pull_code_btn.TabIndex = 3
        Me.pull_code_btn.Text = "PULL CODE"
        Me.pull_code_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Viking Robotics 580"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage2.Controls.Add(Me.LinkLabel2)
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.remote_url_tb)
        Me.TabPage2.Controls.Add(Me.apply_makefilepath_btn)
        Me.TabPage2.Controls.Add(Me.makefile_path_tb)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.apply_flags_btn)
        Me.TabPage2.Controls.Add(Me.additional_flags_tb)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(456, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Config"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(370, 3)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(83, 13)
        Me.LinkLabel2.TabIndex = 10
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "source/liscence"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(339, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "about"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "remote url"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(367, 175)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Apply"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'remote_url_tb
        '
        Me.remote_url_tb.Location = New System.Drawing.Point(15, 149)
        Me.remote_url_tb.Name = "remote_url_tb"
        Me.remote_url_tb.Size = New System.Drawing.Size(425, 20)
        Me.remote_url_tb.TabIndex = 6
        Me.remote_url_tb.Text = "https://github.com/VikingRobotics580/RobotCode2017"
        '
        'apply_makefilepath_btn
        '
        Me.apply_makefilepath_btn.Location = New System.Drawing.Point(367, 60)
        Me.apply_makefilepath_btn.Name = "apply_makefilepath_btn"
        Me.apply_makefilepath_btn.Size = New System.Drawing.Size(75, 23)
        Me.apply_makefilepath_btn.TabIndex = 5
        Me.apply_makefilepath_btn.Text = "Apply"
        Me.apply_makefilepath_btn.UseVisualStyleBackColor = True
        '
        'makefile_path_tb
        '
        Me.makefile_path_tb.Location = New System.Drawing.Point(15, 33)
        Me.makefile_path_tb.Name = "makefile_path_tb"
        Me.makefile_path_tb.Size = New System.Drawing.Size(427, 20)
        Me.makefile_path_tb.TabIndex = 4
        Me.makefile_path_tb.Text = "C:\frc\src\VikingRobotics580\RobotCode2017"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "full path to repository parent folder"
        '
        'apply_flags_btn
        '
        Me.apply_flags_btn.Location = New System.Drawing.Point(367, 120)
        Me.apply_flags_btn.Name = "apply_flags_btn"
        Me.apply_flags_btn.Size = New System.Drawing.Size(75, 23)
        Me.apply_flags_btn.TabIndex = 2
        Me.apply_flags_btn.Text = "Apply"
        Me.apply_flags_btn.UseVisualStyleBackColor = True
        '
        'additional_flags_tb
        '
        Me.additional_flags_tb.Location = New System.Drawing.Point(17, 94)
        Me.additional_flags_tb.Name = "additional_flags_tb"
        Me.additional_flags_tb.Size = New System.Drawing.Size(425, 20)
        Me.additional_flags_tb.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Additional flags"
        '
        'console_output
        '
        Me.console_output.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.console_output.Location = New System.Drawing.Point(-1, 358)
        Me.console_output.Multiline = True
        Me.console_output.Name = "console_output"
        Me.console_output.ReadOnly = True
        Me.console_output.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.console_output.Size = New System.Drawing.Size(456, 78)
        Me.console_output.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Console output"
        '
        'simple_deploy_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(455, 435)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.console_output)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "simple_deploy_form"
        Me.Text = "Simple Deploy"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deploy_code_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents additional_flags_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents console_output As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents apply_flags_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents apply_makefilepath_btn As Button
    Friend WithEvents makefile_path_tb As TextBox
    Friend WithEvents pull_code_btn As Button
    Friend WithEvents kill_robot_btn As Button
    Friend WithEvents deploy_code_simple_btn As Button
    Friend WithEvents build_code_clean_btn As Button
    Friend WithEvents build_code_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents remote_url_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
