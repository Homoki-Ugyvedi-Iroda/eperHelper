' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface eperHelperRegWS_if

    <OperationContract()>
    Function RegisterCode(Code As String) As String

    <OperationContract()>
    Function UploadRegBak(Token As String, Code As String, ServerRegXmlZipped As Byte()) As String

    <OperationContract()>
    Function InvalidateCodebyCode(Token As String, Code As String) As String

    <OperationContract()>
    Function CheckCodeUsable(Token As String, Code As String) As String

    <OperationContract()>
    Function StatusCheck(Token As String) As String

    <OperationContract()>
    Function UploadNewCode(Token As String, CodeList As List(Of String)) As String

    <OperationContract()>
    Function DumpFullDT(Token As String) As String

    <OperationContract()>
    Function ListRegsInPeriod(Token As String, StartDate As Date, EndDate As Date) As String

    <OperationContract()>
    Function DownloadRegBak(Token As String, Code As String) As Byte()

    <OperationContract()>
    Function DownloadRegBakbyId(Token As String, Id As Integer) As Byte()

    <OperationContract()>
    Function DeletebyId(Token As String, IdToDelete As Integer) As Boolean

    <OperationContract()>
    Function SetOtherState(Token As String, IdToChange As Integer, Operation As Integer) As Boolean

    <OperationContract()>
    Function DeleteRegBakbyCode(Token As String, Code As String) As Boolean

    <OperationContract()>
    Function SetRegDate(Token As String, IdToChange As Integer, WhenRegistered As DateTime) As Boolean

    <OperationContract()>
    Function CheckMac(Token As String, macAddresses As String()) As Boolean

    <OperationContract()>
    Function RegisterCodewMAC(Code As String, macAddresses As String()) As Boolean

    <OperationContract()>
    Function ChangeCodewMAC(Token As String, Code As String, macAddresses As String()) As Boolean


End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
