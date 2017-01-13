SOLUTION=countdown.net.sln
XBUILD_FLAGS=/verbosity:normal

.PHONY: all
all: clean build

.PHONY: build
build:
	xbuild $(XBUILD_FLAGS) /p:Configuration=Debug $(SOLUTION)

.PHONY: clean
clean:
	xbuild $(XBUILD_FLAGS) /t:Clean /p:Configuration=Debug $(SOLUTION)
	xbuild $(XBUILD_FLAGS) /t:Clean /p:Configuration=Release $(SOLUTION)
	rm -rf ./countdown.net/bin/
	rm -rf ./countdown.net/obj/

.PHONY: release
release:
	xbuild $(XBUILD_FLAGS) /t:Clean /p:Configuration=Release $(SOLUTION)
	xbuild $(XBUILD_FLAGS) /t:Build /p:Configuration=Release $(SOLUTION)
