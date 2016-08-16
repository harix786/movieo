Option Strict On
Option Infer On

Imports System.ComponentModel

''' <summary>
''' Set Watermark in RichTextbox.
''' </summary>
Public Class RtfExtensions
    Inherits Windows.Forms.RichTextBox
    Private m_watermark As String
    Private m_watermarkColor As Color
    Private m_foreColor As Color
    Private empty As Boolean

    <Browsable(True)>
    Public Property WatermarkColor() As Color
        Get
            Return m_watermarkColor
        End Get
        Set(value As Color)
            m_watermarkColor = value
            If empty Then
                MyBase.ForeColor = m_watermarkColor
            End If
        End Set
    End Property

    <Browsable(True)>
    Public Property Watermark() As String
        Get
            Return m_watermark
        End Get
        Set(value As String)
            m_watermark = value
            If empty Then
                MyBase.Text = m_watermark
                MyBase.ForeColor = m_watermarkColor
            End If
        End Set
    End Property

    Public Sub New()
        empty = True
        m_foreColor = ForeColor
    End Sub

    <Browsable(True)>
    Public Shadows Property ForeColor() As Color
        Get
            Return m_foreColor
        End Get

        Set(value As Color)
            m_foreColor = value
            If Not empty Then
                MyBase.ForeColor = value
            End If
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            If empty Then
                Return ""
            End If
            Return MyBase.Text
        End Get
        Set(value As String)
            If value = "" Then
                empty = True
                MyBase.ForeColor = m_watermarkColor
                MyBase.Text = m_watermark
            Else
                MyBase.Text = value
            End If
        End Set
    End Property

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        If empty Then
            empty = False
            MyBase.ForeColor = m_foreColor
            MyBase.Text = ""
        End If

        MyBase.OnGotFocus(e)
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
        If MyBase.Text = "" Then
            empty = True
            MyBase.ForeColor = m_watermarkColor
            MyBase.Text = m_watermark
        Else
            empty = False
        End If
    End Sub
End Class