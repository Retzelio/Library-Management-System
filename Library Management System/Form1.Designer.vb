﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pdfreader = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.pdfreader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdfreader
        '
        Me.pdfreader.Enabled = True
        Me.pdfreader.Location = New System.Drawing.Point(10, 5)
        Me.pdfreader.Name = "pdfreader"
        Me.pdfreader.OcxState = CType(resources.GetObject("pdfreader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdfreader.Size = New System.Drawing.Size(228, 401)
        Me.pdfreader.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pdfreader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pdfreader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pdfreader As AxAcroPDFLib.AxAcroPDF
End Class
