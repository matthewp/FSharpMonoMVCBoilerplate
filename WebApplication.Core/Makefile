FILES= Global.fs Model.fs HomeController.fs AccountController.fs
RESOURCES = -r System.ComponentModel.DataAnnotations.dll -r System.Core.dll -r System.Web.dll -r System.Web.Abstractions.dll -r System.Web.Mvc.dll -r System.Web.Routing.dll

bin/WebApplication.Core.dll: ${FILES}
	fsharpc -a -o $@ ${FILES} ${RESOURCES}
