
<Serializable()>
Public Class SimpleADBulkUserDomainObject
    Inherits UserDomainObject
    Implements IConvertible

    Private _Errors As List(Of String)
    Public Property Errors As List(Of String)
        Set(value As List(Of String))
            _Errors = value
        End Set
        Get
            Return _Errors
        End Get
    End Property

    Public Function GetTypeCode() As TypeCode Implements IConvertible.GetTypeCode
        Throw New NotImplementedException()
    End Function

    Public Function ToBoolean(provider As IFormatProvider) As Boolean Implements IConvertible.ToBoolean
        Throw New NotImplementedException()
    End Function

    Public Function ToChar(provider As IFormatProvider) As Char Implements IConvertible.ToChar
        Throw New NotImplementedException()
    End Function

    Public Function ToSByte(provider As IFormatProvider) As SByte Implements IConvertible.ToSByte
        Throw New NotImplementedException()
    End Function

    Public Function ToByte(provider As IFormatProvider) As Byte Implements IConvertible.ToByte
        Throw New NotImplementedException()
    End Function

    Public Function ToInt16(provider As IFormatProvider) As Short Implements IConvertible.ToInt16
        Throw New NotImplementedException()
    End Function

    Public Function ToUInt16(provider As IFormatProvider) As UShort Implements IConvertible.ToUInt16
        Throw New NotImplementedException()
    End Function

    Public Function ToInt32(provider As IFormatProvider) As Integer Implements IConvertible.ToInt32
        Throw New NotImplementedException()
    End Function

    Public Function ToUInt32(provider As IFormatProvider) As UInteger Implements IConvertible.ToUInt32
        Throw New NotImplementedException()
    End Function

    Public Function ToInt64(provider As IFormatProvider) As Long Implements IConvertible.ToInt64
        Throw New NotImplementedException()
    End Function

    Public Function ToUInt64(provider As IFormatProvider) As ULong Implements IConvertible.ToUInt64
        Throw New NotImplementedException()
    End Function

    Public Function ToSingle(provider As IFormatProvider) As Single Implements IConvertible.ToSingle
        Throw New NotImplementedException()
    End Function

    Public Function ToDouble(provider As IFormatProvider) As Double Implements IConvertible.ToDouble
        Throw New NotImplementedException()
    End Function

    Public Function ToDecimal(provider As IFormatProvider) As Decimal Implements IConvertible.ToDecimal
        Throw New NotImplementedException()
    End Function

    Public Function ToDateTime(provider As IFormatProvider) As Date Implements IConvertible.ToDateTime
        Throw New NotImplementedException()
    End Function

    Public Function ToString(provider As IFormatProvider) As String Implements IConvertible.ToString
        Throw New NotImplementedException()
    End Function

    Public Function ToType(conversionType As Type, provider As IFormatProvider) As Object Implements IConvertible.ToType
        Throw New NotImplementedException()
    End Function
End Class
