﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.TabControl1 = New Microsoft.VisualBasic.Windows.Forms.TabControl()
        Me.Pane1 = New Microsoft.VisualBasic.Windows.Forms.Gtk.CSSEngine.Components.Pane()
        Me.DividerLabel1 = New Microsoft.VisualBasic.Windows.Forms.Gtk.CSSEngine.Components.DividerLabel()
        Me.Button1 = New Microsoft.VisualBasic.Windows.Forms.Gtk.CSSEngine.Components.Button()
        Me.TabIndicator1 = New Microsoft.VisualBasic.Windows.Forms.TabIndicator()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(41, 169)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(638, 339)
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.TabLabelSkin = Nothing
        '
        'Pane1
        '
        Me.Pane1.BorderColor = System.Drawing.Color.Black
        Me.Pane1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.Pane1.BorderThickness = 5
        Me.Pane1.CanStackItems = True
        Me.Pane1.Location = New System.Drawing.Point(30, 33)
        Me.Pane1.Name = "Pane1"
        Me.Pane1.Padding = New System.Windows.Forms.Padding(5)
        Me.Pane1.Size = New System.Drawing.Size(200, 100)
        Me.Pane1.TabIndex = 2
        '
        'DividerLabel1
        '
        Me.DividerLabel1.AutoSize = True
        Me.DividerLabel1.LineStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.DividerLabel1.Location = New System.Drawing.Point(480, 33)
        Me.DividerLabel1.Name = "DividerLabel1"
        Me.DividerLabel1.Size = New System.Drawing.Size(72, 13)
        Me.DividerLabel1.Spacing = 0
        Me.DividerLabel1.TabIndex = 1
        Me.DividerLabel1.Text = "DividerLabel1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.ImageOver = Nothing
        Me.Button1.ImageUp = Nothing
        Me.Button1.Location = New System.Drawing.Point(300, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'TabIndicator1
        '
        Me.TabIndicator1.DefaultDock = 0
        Me.TabIndicator1.Location = New System.Drawing.Point(41, 139)
        Me.TabIndicator1.Name = "TabIndicator1"
        Me.TabIndicator1.PointerDock = 0
        Me.TabIndicator1.Size = New System.Drawing.Size(553, 15)
        Me.TabIndicator1.Speed = 3
        Me.TabIndicator1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 560)
        Me.Controls.Add(Me.TabIndicator1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Pane1)
        Me.Controls.Add(Me.DividerLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Gtk.CSSEngine.Components.Button
    Friend WithEvents DividerLabel1 As Gtk.CSSEngine.Components.DividerLabel
    Friend WithEvents Pane1 As Gtk.CSSEngine.Components.Pane
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabIndicator1 As TabIndicator
End Class
