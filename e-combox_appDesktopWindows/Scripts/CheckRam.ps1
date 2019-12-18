Get-WmiObject Win32_Service -FIlter "Pathname like '%Docker.Service%'"|
    ForEach-Object{
        $p = Get-Process -PID $_.ProcessID
        $p | Add-Member -MemberType NoteProperty -Name ServiceName -Value $_.Caption -PassThru
    } |
    Sort WS -Descending |
    Select *
   
