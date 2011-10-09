all: 
	$(MAKE) -C WebApplication.Core
	$(MAKE) -C WebApplication

clean:
	rm WebApplication.Core/bin/WebApplication.Core.dll
	rm WebApplication/bin/WebApplication.dll
