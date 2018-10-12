SOLUTION=countdown.net.sln
XBUILD_FLAGS=/verbosity:normal

.PHONY: all
all: clean build

.PHONY: build
build:
	msbuild $(XBUILD_FLAGS) /p:Configuration=Debug $(SOLUTION)

.PHONY: clean
clean:
	msbuild $(XBUILD_FLAGS) /t:Clean /p:Configuration=Debug $(SOLUTION)
	msbuild $(XBUILD_FLAGS) /t:Clean /p:Configuration=Release $(SOLUTION)
	rm -rf ./countdown.net/bin/
	rm -rf ./countdown.net/obj/

.PHONY: release
release:
	msbuild $(XBUILD_FLAGS) /t:Clean /p:Configuration=Release $(SOLUTION)
	msbuild $(XBUILD_FLAGS) /t:Build /p:Configuration=Release $(SOLUTION)
