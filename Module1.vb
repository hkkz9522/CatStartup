Module Module1
    Sub Main()
        Shell("reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v ""Bongo Cat Mver"" /t REG_SZ /d ""\""" + My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe""""", vbHide)
        Shell("cmd /c cd " + My.Application.Info.DirectoryPath + " & ""Bongo Cat Mver.exe""", vbHide)
    End Sub
End Module