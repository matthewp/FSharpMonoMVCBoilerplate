FILES= Properties/AssemblyInfo.cs
RESOURCES = -r:System.ComponentModel.DataAnnotations.dll -r:System.Core.dll -r:System.Web.dll -r:System.Web.Abstractions.dll -r:System.Web.Mvc.dll -r:System.Web.Routing.dll -r:System.Web.Extensions.dll -r:../WebApplication.Core/bin/WebApplication.Core.dll

bin/WebApplication.dll: ${FILES}
	mcs -target:library -out:$@ ${FILES} ${RESOURCES}
	cp ../WebApplication.Core/bin/WebApplication.Core.dll bin/
