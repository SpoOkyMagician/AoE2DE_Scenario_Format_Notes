Imports System
Imports System.IO
Imports System.IO.Compression

Module Program

    Function F_Decompress_File(my_in_file As String, my_out_file As String) As Object

        Dim toDecompress As Byte()
        Dim nowDecompressed As Byte()
        toDecompress = File.ReadAllBytes(my_in_file)

        Using inputStream As New MemoryStream(toDecompress)

            Using outputStream As New MemoryStream()

                Using decompressionStream As New DeflateStream(inputStream, CompressionMode.Decompress)

                    decompressionStream.CopyTo(outputStream)

                End Using

                nowDecompressed = outputStream.ToArray

            End Using

        End Using

        File.WriteAllBytes(my_out_file, nowDecompressed)
        Return Nothing

    End Function

    Function F_Compress_File(my_in_file As String, my_out_file As String) As Object

        Dim toCompress As Byte()
        Dim nowCompressed As Byte()
        toCompress = File.ReadAllBytes(my_in_file)

        Using inputStream As MemoryStream = New MemoryStream(toCompress)

            Using outputStream As MemoryStream = New MemoryStream()

                Using compressionStream As DeflateStream = New DeflateStream(outputStream, CompressionMode.Compress)

                    inputStream.CopyTo(compressionStream)

                End Using

                nowCompressed = outputStream.ToArray()
                File.WriteAllBytes(my_out_file, nowCompressed)

            End Using

        End Using

        Return Nothing

    End Function

    Sub Main()

        ' http://pont.ist/vbnet-compress-decompress-byte-array/
        ' F_Compress_File("D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER_EDIT_TRIGGERS.aoe2scenario", "D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER_EDIT_TRIGGERS_OUTPUT.aoe2scenario")
        ' F_Decompress_File("D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER_OUTPUT.aoe2scenario", "D:\scenario_tests\_ALL_SCENARIO_STUFF_OBJECTS_MINUS_HEADER.aoe2scenario") ' we need to reverse this...

    End Sub

End Module
