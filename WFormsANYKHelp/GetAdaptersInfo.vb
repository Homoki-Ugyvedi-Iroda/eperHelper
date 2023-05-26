Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Text

Public Class GetAdaptersInfoClass
    Const MAX_ADAPTER_DESCRIPTION_LENGTH As Integer = 128
    Const ERROR_BUFFER_OVERFLOW As Integer = 111
    Const MAX_ADAPTER_NAME_LENGTH As Integer = 256
    Const MAX_ADAPTER_ADDRESS_LENGTH As Integer = 8
    Const MIB_IF_TYPE_OTHER As Integer = 1
    Const MIB_IF_TYPE_ETHERNET As Integer = 6
    Const MIB_IF_TYPE_TOKENRING As Integer = 9
    Const MIB_IF_TYPE_FDDI As Integer = 15
    Const MIB_IF_TYPE_PPP As Integer = 23
    Const MIB_IF_TYPE_LOOPBACK As Integer = 24
    Const MIB_IF_TYPE_SLIP As Integer = 28


    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Private Structure IP_ADDRESS_STRING
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=(4 * 4))>
        Dim value As String
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Public Class IP_ADAPTER_INFO
        Public [Next] As IntPtr
        Public ComboIndex As Int32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=(MAX_ADAPTER_NAME_LENGTH + 4))>
        Public AdapterName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=(MAX_ADAPTER_DESCRIPTION_LENGTH + 4))>
        Public AdapterDescription As String
        Public AddressLength As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=(MAX_ADAPTER_ADDRESS_LENGTH))>
        Public Address() As Byte
        Public Index As Int32
        Public Type As Int32
        Public DhcpEnabled As Int32
        Public CurrentIpAddress As Int32
        Public HaveWins As Int32
        Public LeaseObtained As Int32
        Public LeaseExpires As Int32
    End Class

    Friend Shared Function GetAllMacAddresses() As List(Of String)
        Dim MACsNI, MACsGA As New List(Of String)
        Try
            MACsNI = GetAdaptersInfoClass.getAllMacAddressesNI
            MACsGA = GetAdaptersInfoClass.getAllMacAddressesGA
            For Each itemGA In MACsGA
                If Not MACsNI.Contains(itemGA) Then MACsNI.Add(itemGA)
            Next
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "MAC ellenőrzési hiba; MACsNI=" & MACsNI.Count & " MACsGA=" & MACsGA.Count, LogTip.err)
        End Try
        Return MACsNI
    End Function

    Friend Shared Function GetAllMacAddressesSingle() As String
        Dim tempList As List(Of String) = GetAllMacAddresses()
        Dim sb As New StringBuilder
        For Each s As String In tempList
            sb.Append(s).Append(";")
        Next
        Return sb.ToString()
    End Function

    Friend Shared Function GetAllMacAddressesfromGASingle() As String
        Dim tempList As List(Of String) = getAllMacAddressesGA()
        Dim sb As New StringBuilder
        For Each s As String In tempList
            sb.Append(s).Append(";")
        Next
        Return sb.ToString()
    End Function


    Friend Shared Function GetAllMacAddressesNISingle() As String
        Dim tempList As List(Of String) = getAllMacAddressesNI()
        Dim sb As New StringBuilder
        For Each s As String In tempList
            sb.Append(s).Append(";")
        Next
        Return sb.ToString()
    End Function

    Friend Shared Function getAllMacAddressesNI() As List(Of String)
        'http://stackoverflow.com/questions/13025878/geting-mac-address-by-using-vb-net-2010
        Dim myMac As New List(Of String)
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac.Add(adapter.GetPhysicalAddress.ToString)
                            Exit For
                        End If

                End Select
            Next adapter
            Return myMac
        Catch ex As Exception
            Return myMac
        End Try
    End Function

    Public Shared Function getAllMacAddressesGA() As List(Of String)
        Dim structSize As Long = Marshal.SizeOf(GetType(IP_ADAPTER_INFO))
        Dim pArray As IntPtr = Marshal.AllocHGlobal(New IntPtr(structSize))
        Dim response As New List(Of String)
        Dim ret As Integer = ANYHelpModule.GetAdaptersInfo(pArray, structSize)

        If ret = ERROR_BUFFER_OVERFLOW Then
            ' ERROR_BUFFER_OVERFLOW == 111
            ' Buffer was too small, reallocate the correct size for the buffer.
            pArray = Marshal.ReAllocHGlobal(pArray, New IntPtr(structSize))

            ret = ANYHelpModule.GetAdaptersInfo(pArray, structSize)
        End If
        ' if
        If ret = 0 Then
            ' Call Succeeded
            Dim pEntry As IntPtr = pArray

            Do
                ' Retrieve the adapter info from the memory address
                Dim entry As IP_ADAPTER_INFO = DirectCast(Marshal.PtrToStructure(pEntry, GetType(IP_ADAPTER_INFO)), IP_ADAPTER_INFO)
                Dim tmpString As String = String.Empty
                For i As Integer = 0 To entry.AddressLength - 2
                    tmpString += String.Format("{0:X2}", entry.Address(i))
                Next
                response.Add(String.Format("{0}{1:X2}", tmpString, entry.Address(entry.AddressLength - 1)))
                pEntry = entry.[Next]
            Loop While pEntry <> IntPtr.Zero

            Marshal.FreeHGlobal(pArray)
        Else
            ' if
            Marshal.FreeHGlobal(pArray)
            Throw New InvalidOperationException("Adapter adatgyűjtési hiba: " + ret)
        End If
        Return response
    End Function

End Class
