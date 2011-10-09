all: 
	$(MAKE) -C WebApplication.Core
	$(MAKE) -C WebApplication

clean:
	rm -f WebApplication.Core/bin/WebApplication.Core.dll
	rm -f WebApplication/bin/WebApplication.dll
