﻿Imports System.Drawing
Imports Microsoft.VisualBasic.Imaging.Math2D

''' <summary>
''' The routes blocker
''' </summary>
Public MustInherit Class Block

    ''' <summary>
    ''' The center location of this block object.
    ''' </summary>
    ''' <returns></returns>
    Public MustOverride ReadOnly Property Location As Point

    Public MustOverride Function Intersect(a As PointF, b As PointF) As Boolean

End Class

Public Class rect : Inherits Block

    Public ReadOnly rectangle As Rectangle

    Public Overrides ReadOnly Property Location As Point
        Get
            Return rectangle.Centre
        End Get
    End Property

    Public Overrides Function Intersect(a As PointF, b As PointF) As Boolean
        If a.InRegion(rectangle) OrElse b.InRegion(rectangle) Then
            Return True
        Else

        End If
    End Function
End Class

Public Class Circle : Inherits Block

    Public Property center As Point
    Public Property radius As Single

    Public Overrides ReadOnly Property Location As Point
        Get
            Return center
        End Get
    End Property

    Public Overrides Function Intersect(a As PointF, b As PointF) As Boolean
        If Distance(a, center) <= radius OrElse Distance(b, center) <= radius Then
            Return True
        Else

        End If
    End Function
End Class