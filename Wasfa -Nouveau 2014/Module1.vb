Imports System.Management
Imports System.Security.Cryptography
Imports System.Text

Module Module1
    Public A As Integer = -1
    Public B As Integer = -1
    Public txtHeureSortie1, txtDatePrint As String
    Public txtHeureSortie2 As String

    Public txtHeureSortieR1 As String
    Public txtHeureSortieR2 As String
    Public Function GetHDDSerial() As String
        Dim hdd As New ManagementObjectSearcher("select * from win32_DiskDrive")
        Dim aa As String = String.Empty
        For Each hd In hdd.Get
            aa = (hd("serialNumber"))
        Next
        Return aa
    End Function
    Public Function GetVolumeSerialNumber(Optional ByVal strDriveLetter As String = "C") As String
        Dim Disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
        Disk.Get()
        Return Disk("VolumeSerialNumber").ToString

    End Function
    Public Function GetMyNewIDHDD() As String
        Dim DriveSerial As Long
        Dim fso As Object, Dvr As Object
        fso = CreateObject("Scripting.FileSystemObject")
        Dvr = fso.getDrive(fso.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
        With Dvr
            If .isReady Then
                DriveSerial = .serialNumber
            Else
                DriveSerial = -1
            End If
        End With
        Return Hex(DriveSerial)
    End Function
    Function GetSerialBIOS() As String
        Dim a As New SelectQuery("win32_bios")
        Dim search As New ManagementObjectSearcher(a)
        Dim info As New ManagementObject
        Dim zz As String = "Error"

        For Each info In search.Get
            zz = (info("serialnumber").ToString)
        Next

        Dim i As Integer = 4
        Do While i + 1 <= zz.Length
            zz = zz.Substring(0, i) & "-" & zz.Substring(i)
            i = i + 5
        Loop

        Return zz
    End Function
    Private Function ComputeMD5HashForString(ByVal String2Hash As String) As String
        Try
            Dim MD5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()

            Dim oEncoder As New System.Text.ASCIIEncoding()
            Dim bytes As Byte() = oEncoder.GetBytes(String2Hash)

            Dim myHash As Byte() = MD5Hasher.ComputeHash(bytes)
            Dim myCapacity As Integer = (myHash.Length * 2 + (myHash.Length / 8))
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(myCapacity)
            Dim I As Integer
            For I = 0 To myHash.Length - 1
                sb.Append(BitConverter.ToString(myHash, I, 1))
            Next I
            Return sb.ToString().TrimEnd(New Char() {" "c})
        Catch ex As Exception
            Return "0"
        End Try
    End Function
    Public Function ReturnKey(ByVal S As String) As String
        On Error Resume Next
        Dim origBytes() As Byte, newBytes() As Byte, sFinal As String
        Dim md5 As New MD5CryptoServiceProvider
        origBytes = ASCIIEncoding.Default.GetBytes(S)
        newBytes = md5.ComputeHash(origBytes)
        '
        sFinal = ReturnKey1(ReturnKey1("LailahaIlaLah" & BitConverter.ToString(newBytes).Replace("-", vbNullString).ToUpper))
        Return sFinal.Substring(0, 4) & "-" & sFinal.Substring(4)
    End Function
    Public Function ReturnKey1(ByVal S As String) As String
        On Error Resume Next
        Dim origBytes() As Byte, newBytes() As Byte, sFinal As String
        Dim md5 As New MD5CryptoServiceProvider
        origBytes = ASCIIEncoding.Default.GetBytes(S)
        newBytes = md5.ComputeHash(origBytes)
        '
        sFinal = BitConverter.ToString(newBytes).Replace("-", vbNullString).ToUpper
        Return sFinal.Substring(0, 8) & "-" & sFinal.Substring(8)
    End Function
End Module
