# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.2

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list

# Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/local/Cellar/cmake/3.2.2/bin/cmake

# The command to remove a file.
RM = /usr/local/Cellar/cmake/3.2.2/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /Users/lab430/Documents/HeadTrackingProject/wiiuse-master

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build

# Include any dependencies generated for this target.
include example/CMakeFiles/wiiuseServer.dir/depend.make

# Include the progress variables for this target.
include example/CMakeFiles/wiiuseServer.dir/progress.make

# Include the compile flags for this target's objects.
include example/CMakeFiles/wiiuseServer.dir/flags.make

example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o: example/CMakeFiles/wiiuseServer.dir/flags.make
example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o: ../example/wiiServer.cpp
	$(CMAKE_COMMAND) -E cmake_progress_report /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/CMakeFiles $(CMAKE_PROGRESS_1)
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Building CXX object example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o"
	cd /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example && /Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++   $(CXX_DEFINES) $(CXX_FLAGS) -o CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o -c /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/example/wiiServer.cpp

example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/wiiuseServer.dir/wiiServer.cpp.i"
	cd /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example && /Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_FLAGS) -E /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/example/wiiServer.cpp > CMakeFiles/wiiuseServer.dir/wiiServer.cpp.i

example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/wiiuseServer.dir/wiiServer.cpp.s"
	cd /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example && /Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_FLAGS) -S /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/example/wiiServer.cpp -o CMakeFiles/wiiuseServer.dir/wiiServer.cpp.s

example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.requires:
.PHONY : example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.requires

example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.provides: example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.requires
	$(MAKE) -f example/CMakeFiles/wiiuseServer.dir/build.make example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.provides.build
.PHONY : example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.provides

example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.provides.build: example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o

# Object files for target wiiuseServer
wiiuseServer_OBJECTS = \
"CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o"

# External object files for target wiiuseServer
wiiuseServer_EXTERNAL_OBJECTS =

example/wiiuseServer: example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o
example/wiiuseServer: example/CMakeFiles/wiiuseServer.dir/build.make
example/wiiuseServer: src/libwiiuse.a
example/wiiuseServer: example/CMakeFiles/wiiuseServer.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --red --bold "Linking CXX executable wiiuseServer"
	cd /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example && $(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/wiiuseServer.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
example/CMakeFiles/wiiuseServer.dir/build: example/wiiuseServer
.PHONY : example/CMakeFiles/wiiuseServer.dir/build

example/CMakeFiles/wiiuseServer.dir/requires: example/CMakeFiles/wiiuseServer.dir/wiiServer.cpp.o.requires
.PHONY : example/CMakeFiles/wiiuseServer.dir/requires

example/CMakeFiles/wiiuseServer.dir/clean:
	cd /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example && $(CMAKE_COMMAND) -P CMakeFiles/wiiuseServer.dir/cmake_clean.cmake
.PHONY : example/CMakeFiles/wiiuseServer.dir/clean

example/CMakeFiles/wiiuseServer.dir/depend:
	cd /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/lab430/Documents/HeadTrackingProject/wiiuse-master /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/example /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example /Users/lab430/Documents/HeadTrackingProject/wiiuse-master/build/example/CMakeFiles/wiiuseServer.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : example/CMakeFiles/wiiuseServer.dir/depend
