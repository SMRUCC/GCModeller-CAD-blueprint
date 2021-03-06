﻿Imports System.Drawing
Imports Microsoft.VisualBasic.ComponentModel.Collection.Generic
Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel.Repository
Imports Microsoft.VisualBasic.Imaging.Math2D

Namespace Canvas

    ''' <summary>
    ''' The routes blocker
    ''' </summary>
    Public MustInherit Class Block : Implements INamedValue

        ''' <summary>
        ''' The center location of this block object.
        ''' </summary>
        ''' <returns></returns>
        Public MustOverride ReadOnly Property Location As Point
        ''' <summary>
        ''' 基因编号或者代谢物的编号
        ''' </summary>
        ''' <returns></returns>
        Public Property ID As String Implements IKeyedEntity(Of String).Key
        Public Property Name As String

        Public MustOverride Function Intersect(a As PointF, b As PointF) As Boolean

    End Class

    Public Class rect : Inherits Block

        Public Property rectangle As Rectangle
            Get
                Return rect
            End Get
            Set(value As Rectangle)
                rect = value
                polygon = New Polygon(rect)
            End Set
        End Property

        Dim rect As Rectangle
        Dim polygon As Polygon

        Public Overrides ReadOnly Property Location As Point
            Get
                Return rectangle.Centre
            End Get
        End Property

        Public Overrides Function Intersect(a As PointF, b As PointF) As Boolean
            If a.InRegion(rectangle) OrElse b.InRegion(rectangle) Then
                Return True
            Else
                Return New Line(a, b).IntersectionOf(polygon) <> Intersection.None
            End If
        End Function
    End Class

    Public Class Circle : Inherits Block

        Public Property center As Point
        Public Property radius As Single

        Dim polygon As Polygon

        Public Overrides ReadOnly Property Location As Point
            Get
                Return center
            End Get
        End Property

        Public Overrides Function Intersect(a As PointF, b As PointF) As Boolean
            If polygon.Points Is Nothing Then
                polygon = New Polygon(New Rectangle(center, New Size(radius, radius)))
            End If

            If Distance(a, center) <= radius OrElse Distance(b, center) <= radius Then
                Return True
            Else
                Return New Line(a, b).IntersectionOf(polygon) <> Intersection.None
            End If
        End Function
    End Class
End Namespace