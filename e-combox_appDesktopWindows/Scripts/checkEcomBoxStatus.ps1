#Check if e-comBox is started

#$info_docker = (docker info)

#if ($info_docker -ilike "*error*") {
#	Write-host "Stopped"
#} else {
#	$ecomboxStarted = (docker ps -f name=e-comBox)
#	if ($ecomboxStarted) {
		Write-host "Started"
#	} else {
#		Write-host "Stopped"
#	}
#}