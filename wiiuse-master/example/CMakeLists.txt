include_directories(../src)
add_executable(wiiuseServer wiiServer.cpp)
target_link_libraries(wiiuseServer wiiuse)

if(INSTALL_EXAMPLES)
	install(TARGETS wiiuseServer
		RUNTIME DESTINATION bin COMPONENT examples)
endif()