﻿Imports System.Data.SqlClient

Public Class fdetalleservicio
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal dts As vdetalleservicio) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalleservicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function ingresar(ByVal dts As vdetalleservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_detalleservicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@idservicio", dts.gidservicio)
            cmd.Parameters.AddWithValue("@idempleado", dts.gidempleado)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@preciounitario", dts.gpreciounitario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vdetalleservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalleservicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@iddetalleservicio", dts.giddetalleservicio)
            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@idservicio", dts.gidservicio)
            cmd.Parameters.AddWithValue("@idempleado", dts.gidempleado)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@preciounitario", dts.gpreciounitario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalleservicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@iddetalleservicio", dts.gidventa)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class